using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tati_thiago_dos_santos_p1
{
    public partial class LearnBackgroundWorker: Form
    {
        public LearnBackgroundWorker()
        {
            InitializeComponent();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            for (int i = 1; i <= 10; i++) {
                System.Threading.Thread.Sleep(300);
                bgWorker.ReportProgress(i);
            }
        }


        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            txtLog.Text += "Processando item " + e.ProgressPercentage + "...\r\n";
            pgrsBar.Value += 1;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            txtLog.Text += "Processamento concluído...\r\n";
            MessageBox.Show("Processamento concluído!");
            pgrsBar.Value = 0;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            pgrsBar.Value = 0;
            pgrsBar.Maximum = 10;
            bgWorker.RunWorkerAsync();
            txtLog.Text = "Processamento iniciado...\r\n";
        }
    }
}
