namespace tati_thiago_dos_santos_p1 {
    partial class WarSpoting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listView = new System.Windows.Forms.ListView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnConsultarPerdas = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(9, 113);
            this.listView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(938, 251);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(9, 10);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(9, 372);
            this.listBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(938, 69);
            this.listBox.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(10, 446);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(935, 19);
            this.progressBar.TabIndex = 4;
            // 
            // btnConsultarPerdas
            // 
            this.btnConsultarPerdas.Location = new System.Drawing.Point(244, 8);
            this.btnConsultarPerdas.Name = "btnConsultarPerdas";
            this.btnConsultarPerdas.Size = new System.Drawing.Size(107, 23);
            this.btnConsultarPerdas.TabIndex = 5;
            this.btnConsultarPerdas.Text = "Consultar perdas";
            this.btnConsultarPerdas.UseVisualStyleBackColor = true;
            this.btnConsultarPerdas.Click += new System.EventHandler(this.btnConsultarPerdas_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            // 
            // WarSpoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 480);
            this.Controls.Add(this.btnConsultarPerdas);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WarSpoting";
            this.Text = "War Spoting";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnConsultarPerdas;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}