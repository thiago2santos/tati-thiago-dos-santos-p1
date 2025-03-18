using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tati_thiago_dos_santos_p1
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = false;
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private async void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            string url = "https://jsonplaceholder.typicode.com/posts/1"; // Exemplo de API pública
            e.Result = await FetchDataAsync(url);
        }

        private async Task<object> FetchDataAsync(string url) {
            using (HttpClient client = new HttpClient()) {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error != null) {
                MessageBox.Show($"Erro: {e.Error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if (e.Result != null) {
                    txtResult.Text = e.Result.ToString();
                } else {
                    txtResult.Text = "Nenhum resultado";
                }
            }
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.Value = 0;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (!backgroundWorker.IsBusy) {
                txtResult.Clear();
                progressBar.Style = ProgressBarStyle.Marquee;
                backgroundWorker.RunWorkerAsync();
            }
        }
    }
}
