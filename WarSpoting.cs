using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace tati_thiago_dos_santos_p1 {
    public partial class WarSpoting : Form {
        public WarSpoting() {
            InitializeComponent();
        }

        private async Task<LossResponse> GetLossesAsync(string date) {
            string url = $"https://ukr.warspotting.net/api/losses/russia/{date}/";
            using (HttpClient client = new HttpClient()) {
                client.Timeout = TimeSpan.FromSeconds(100);
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LossResponse>(responseBody);
            }
        }

        private void dateTimePicker_Enter(object sender, EventArgs e) {
            listView.Items.Clear();
            listBox.Items.Clear();
            progressBar.Value = 0;
        }

        private async void btnConsultarPerdas_Click(object sender, EventArgs e) {
            string formattedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            listBox.Items.Add($"Consultando perdas para a data: {formattedDate}");

            Cursor.Current = Cursors.WaitCursor; // Muda o cursor para o de espera

            try {
                LossResponse lossResponse = await GetLossesAsync(formattedDate);
                listBox.Items.Add("Dados recebidos. Preenchendo ListView...");

                progressBar.Minimum = 0;
                progressBar.Maximum = lossResponse.Losses.Count;
                progressBar.Value = 0;

                listView.Items.Clear();
                if (lossResponse.Losses.Count == 0) {
                    listBox.Items.Add("Nenhuma perda encontrada para a data selecionada.");
                } else {
                    foreach (var loss in lossResponse.Losses) {
                        ListViewItem item = new ListViewItem(loss.Id.ToString());
                        item.SubItems.Add(loss.Type);
                        item.SubItems.Add(loss.Model);
                        item.SubItems.Add(loss.Status);
                        item.SubItems.Add(loss.LostBy);
                        item.SubItems.Add(loss.Date.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(loss.NearestLocation);
                        item.SubItems.Add(loss.Geo);
                        item.SubItems.Add(loss.Unit ?? "N/A");
                        item.SubItems.Add(loss.Tags != null ? string.Join(", ", loss.Tags) : "N/A");
                        listView.Items.Add(item);
                        progressBar.Value++;
                    }
                    listBox.Items.Add("ListView preenchido com sucesso.");
                }
            } catch (HttpRequestException ex) {
                listBox.Items.Add($"Erro na requisição: {ex.Message}");
            } finally {
                Cursor.Current = Cursors.Default; // Restaura o cursor padrão
            }
        }
    }
}
