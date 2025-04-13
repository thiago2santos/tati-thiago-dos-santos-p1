using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CefSharp;
using CefSharp.WinForms;

namespace tati_thiago_dos_santos_p1 {
    public partial class WarSpoting : Form {
        public ChromiumWebBrowser chromeBrowser;

        public void InitializeChromium() {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://fatecjd.edu.br/site/");
            // Add it to the form and fill it to the form window.
            this.tabLocalizacao.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private LossResponse lossResponse { get; set; }

        public WarSpoting() {
            InitializeComponent();
            InitializeChromium();
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Tipo", 150);
            listView.Columns.Add("Modelo", 150);
            listView.Columns.Add("Status", 100);
            listView.Columns.Add("Data", 100);
            listView.Columns.Add("Geo", 100);
            listView.Columns.Add("Unidade", 100);
            listView.Columns.Add("Tags", 150);
        }

        private async Task<LossResponse> GetLossesAsync(string date) {
            string url = $"https://ukr.warspotting.net/api/losses/russia/{date}/";
            using (HttpClient client = new HttpClient()) {
                //LossResponse lossResponse = null;
                client.Timeout = TimeSpan.FromSeconds(3);
                try {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    lossResponse = JsonConvert.DeserializeObject<LossResponse>(responseBody);
                } catch (TaskCanceledException ex) {
                    bgWorker.CancelAsync();
                    listBox.Items.Add("A requisição foi cancelada. O tempo limite foi atingido.");
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
                LossResponse lossResponse = await GetLossesAsync(formattedDate);

                if (lossResponse != null && lossResponse.Losses.Count != 0) {
                    progressBar.Value = 0;
                    progressBar.Minimum = 0;
                    progressBar.Maximum = lossResponse.Losses.Count;

                    listBox.Items.Add("Dados recebidos. Preenchendo ListView...");

                    foreach (var loss in lossResponse.Losses) {
                        ListViewItem item = new ListViewItem(loss.Id.ToString());
                        item.SubItems.Add(loss.Type);
                        item.SubItems.Add(loss.Model);
                        item.SubItems.Add(loss.Status);
                        item.SubItems.Add(loss.Date.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(loss.Geo);
                        item.SubItems.Add(loss.Unit ?? "N/A");
                        item.SubItems.Add(loss.Tags != null ? string.Join(", ", loss.Tags) : "N/A");
                        listView.Items.Add(item);
                        progressBar.Value++;
                    }
                    listBox.Items.Add("ListView preenchido com sucesso.");

                    PreencherFiltros(lossResponse);


                } else if (lossResponse != null && lossResponse.Losses.Count == 0) {
                    listBox.Items.Add("Nenhuma perda encontrada para a data selecionada.");
                }
            } catch (HttpRequestException ex) {
                listBox.Items.Add($"Erro na requisição: {ex.Message}");
            } finally {
                progressBar.Value = 0;            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void PreencherFiltros(LossResponse lossResponse) {
            // Preenche o ComboBox de Tipo
            cBoxTipo.Items.Clear();
            cBoxTipo.Items.Add("Todos");
            lossResponse.Losses.ForEach(l => {
                if (!cBoxTipo.Items.Contains(l.Type)) {
                    cBoxTipo.Items.Add(l.Type);
                }
            });
            cBoxTipo.SelectedIndex = 0;

            // Preenche o ComboBox de Modelo
            cBoxModelo.Items.Clear();
            cBoxModelo.Items.Add("Todos");
            lossResponse.Losses.ForEach(l => {
                if (!cBoxModelo.Items.Contains(l.Model)) {
                    cBoxModelo.Items.Add(l.Model);
                }
            });
            cBoxModelo.SelectedIndex = 0;

            // Preenche o ComboBox de Status
            cBoxStatus.Items.Clear();
            cBoxStatus.Items.Add("Todos");
            lossResponse.Losses.ForEach(l => {
                if (!cBoxStatus.Items.Contains(l.Status)) {
                    cBoxStatus.Items.Add(l.Status);
                }
            });
            cBoxStatus.SelectedIndex = 0;
        }

        private void cBoxTipo_SelectedIndexChanged(object sender, EventArgs e) {
            listView.Items.Clear();
            foreach (var loss in lossResponse.Losses) {
                if (cBoxTipo.SelectedItem.ToString() == "Todos" || loss.Type == cBoxTipo.SelectedItem.ToString()) {
                    ListViewItem item = new ListViewItem(loss.Id.ToString());
                    item.SubItems.Add(loss.Type);
                    item.SubItems.Add(loss.Model);
                    item.SubItems.Add(loss.Status);
                    item.SubItems.Add(loss.Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(loss.Geo);
                    item.SubItems.Add(loss.Unit ?? "N/A");
                    item.SubItems.Add(loss.Tags != null ? string.Join(", ", loss.Tags) : "N/A");
                    listView.Items.Add(item);
                }
            }
        }

        private void cBoxModelo_SelectedIndexChanged(object sender, EventArgs e) {
            listView.Items.Clear();
            foreach (var loss in lossResponse.Losses) {
                if (cBoxModelo.SelectedItem.ToString() == "Todos" || loss.Model == cBoxModelo.SelectedItem.ToString()) {
                    ListViewItem item = new ListViewItem(loss.Id.ToString());
                    item.SubItems.Add(loss.Type);
                    item.SubItems.Add(loss.Model);
                    item.SubItems.Add(loss.Status);
                    item.SubItems.Add(loss.Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(loss.Geo);
                    item.SubItems.Add(loss.Unit ?? "N/A");
                    item.SubItems.Add(loss.Tags != null ? string.Join(", ", loss.Tags) : "N/A");
                    listView.Items.Add(item);
                }
            }
        }

        private void cBoxStatus_SelectedIndexChanged(object sender, EventArgs e) {
            listView.Items.Clear();
            foreach (var loss in lossResponse.Losses) {
                if (cBoxStatus.SelectedItem.ToString() == "Todos" || loss.Status == cBoxStatus.SelectedItem.ToString()) {
                    ListViewItem item = new ListViewItem(loss.Id.ToString());
                    item.SubItems.Add(loss.Type);
                    item.SubItems.Add(loss.Model);
                    item.SubItems.Add(loss.Status);
                    item.SubItems.Add(loss.Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(loss.Geo);
                    item.SubItems.Add(loss.Unit ?? "N/A");
                    item.SubItems.Add(loss.Tags != null ? string.Join(", ", loss.Tags) : "N/A");
                    listView.Items.Add(item);
                }
            }
        }

        private void radioBContribuicaoUnica_CheckedChanged(object sender, EventArgs e) {
            grpBoxContribuicaoUnica.Enabled = true;
            grpBoxContribuicaoUnica.Visible = true;
            grpBoxContribuicaoMensal.SendToBack();  
            grpBoxContribuicaoUnica.BringToFront();
            grpBoxContribuicaoUnica.Location = new System.Drawing.Point(28, 58);
        }

        private void radioBContribuicaoMensal_CheckedChanged(object sender, EventArgs e) {
            grpBoxContribuicaoMensal.Enabled = true;
            grpBoxContribuicaoMensal.Visible = true;
            grpBoxContribuicaoMensal.BringToFront();
            grpBoxContribuicaoMensal.Location = new System.Drawing.Point(28, 58);
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e) {
            cBoxTipo.SelectedIndex = 0;
            cBoxModelo.SelectedIndex = 0;
            cBoxStatus.SelectedIndex = 0;
        }

        private void txtDoarOutroValorMensal_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true; // Bloqueia a entrada
                toolStripStatusLabel.Text = "Apenas números são permitidos.";   
            }
        }

        private void txtDoarOutroValorMensal_KeyDown(object sender, KeyEventArgs e) {
            toolStripStatusLabel.Text = "";
        }

        private void txtOutroValorUnico_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true; // Bloqueia a entrada
                toolStripStatusLabel.Text = "Apenas números são permitidos.";
            }
        }

        private void txtOutroValorUnico_KeyDown(object sender, KeyEventArgs e) {
            toolStripStatusLabel.Text = ""; 
        }

        private void WarSpoting_Load(object sender, EventArgs e) {

        }
    }
}

