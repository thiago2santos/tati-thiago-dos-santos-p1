using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace tati_thiago_dos_santos_p1 {
    public partial class WarSpoting : Form {
        public WarSpoting() {
            InitializeComponent();
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Tipo", 150);
            listView.Columns.Add("Modelo", 150);
            listView.Columns.Add("Status", 100);
            //listView.Columns.Add("Perdido por", 100);
            listView.Columns.Add("Data", 100);
            //listView.Columns.Add("Local mais próximo", 100);
            listView.Columns.Add("Geo", 100);
            listView.Columns.Add("Unidade", 100);
            listView.Columns.Add("Tags", 150);
        }

        private async Task<LossResponse> GetLossesAsync(string date) {
            string url = $"https://ukr.warspotting.net/api/losses/russia/{date}/";
            using (HttpClient client = new HttpClient()) {
                LossResponse lossResponse = null;
                client.Timeout = TimeSpan.FromSeconds(3);
                try {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    lossResponse = JsonConvert.DeserializeObject<LossResponse>(responseBody);
                } catch (TaskCanceledException ex) {
                    bgWorker.CancelAsync();
                }
                return lossResponse;
            }
        }

        private async void btnConsultarPerdas_Click(object sender, EventArgs e) {
            progressBar.Value = 0;
            listBox.Items.Clear();
            listView.Items.Clear();

            string formattedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            listBox.Items.Add($"Consultando perdas para a data: {formattedDate}");

            try {
                bgWorker.RunWorkerAsync(); // Inicia o processamento em segundo plano
                LossResponse lossResponse = await GetLossesAsync(formattedDate);

                if (lossResponse == null || lossResponse.Losses.Count == 0) {
                    listBox.Items.Add("Nenhuma perda encontrada para a data selecionada.");
                    bgWorker.CancelAsync();
                } else {
                    bgWorker.CancelAsync();
                    progressBar.Value = 0;
                    progressBar.Minimum = 0;
                    progressBar.Maximum = lossResponse.Losses.Count;

                    listBox.Items.Add("Dados recebidos. Preenchendo ListView...");
                    foreach (var loss in lossResponse.Losses) {
                        ListViewItem item = new ListViewItem(loss.Id.ToString());
                        item.SubItems.Add(loss.Type);
                        item.SubItems.Add(loss.Model);
                        item.SubItems.Add(loss.Status);
                        //item.SubItems.Add(loss.LostBy);
                        item.SubItems.Add(loss.Date.ToString("yyyy-MM-dd"));
                        //item.SubItems.Add(loss.NearestLocation);
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
            }
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            for (int i = 0; i < 100; i++) {
                if (!bgWorker.CancellationPending){
                    System.Threading.Thread.Sleep(100);
                    bgWorker.ReportProgress(i);
                }
            }
        }

        private void bgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {

        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            listBox.Items.Add("Processamento concluído.");
            progressBar.Value = 0;
        }
    }
}
