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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnConsultarPerdas = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblData = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpBoxContribuicaoMensal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoarOutroValorMensal = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioBContribuicaoMensal = new System.Windows.Forms.RadioButton();
            this.radioBContribuicaoUnica = new System.Windows.Forms.RadioButton();
            this.grpBoxContribuicaoUnica = new System.Windows.Forms.GroupBox();
            this.lblOutroValorUnico = new System.Windows.Forms.Label();
            this.txtOutroValorUnico = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioB75 = new System.Windows.Forms.RadioButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.cBoxModelo = new System.Windows.Forms.ComboBox();
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpBoxContribuicaoMensal.SuspendLayout();
            this.grpBoxContribuicaoUnica.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(10, 65);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 372);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(920, 69);
            this.listBox.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(10, 446);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(922, 19);
            this.progressBar.TabIndex = 4;
            // 
            // btnConsultarPerdas
            // 
            this.btnConsultarPerdas.AutoSize = true;
            this.btnConsultarPerdas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarPerdas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultarPerdas.Location = new System.Drawing.Point(244, 65);
            this.btnConsultarPerdas.Name = "btnConsultarPerdas";
            this.btnConsultarPerdas.Size = new System.Drawing.Size(100, 22);
            this.btnConsultarPerdas.TabIndex = 1;
            this.btnConsultarPerdas.Text = "Consultar perdas";
            this.btnConsultarPerdas.UseVisualStyleBackColor = true;
            this.btnConsultarPerdas.Click += new System.EventHandler(this.btnConsultarPerdas_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(950, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(9, 32);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(101, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Selecione uma data";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(10, 105);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(928, 257);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalhes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(5, 5);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(910, 221);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Localização";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.CausesValidation = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(914, 225);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioBContribuicaoMensal);
            this.tabPage3.Controls.Add(this.radioBContribuicaoUnica);
            this.tabPage3.Controls.Add(this.grpBoxContribuicaoUnica);
            this.tabPage3.Controls.Add(this.grpBoxContribuicaoMensal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(920, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Patrocinar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpBoxContribuicaoMensal
            // 
            this.grpBoxContribuicaoMensal.Controls.Add(this.label1);
            this.grpBoxContribuicaoMensal.Controls.Add(this.txtDoarOutroValorMensal);
            this.grpBoxContribuicaoMensal.Controls.Add(this.radioButton5);
            this.grpBoxContribuicaoMensal.Controls.Add(this.radioButton6);
            this.grpBoxContribuicaoMensal.Controls.Add(this.radioButton7);
            this.grpBoxContribuicaoMensal.Controls.Add(this.radioButton8);
            this.grpBoxContribuicaoMensal.Controls.Add(this.radioButton9);
            this.grpBoxContribuicaoMensal.Location = new System.Drawing.Point(28, 58);
            this.grpBoxContribuicaoMensal.Name = "grpBoxContribuicaoMensal";
            this.grpBoxContribuicaoMensal.Size = new System.Drawing.Size(324, 101);
            this.grpBoxContribuicaoMensal.TabIndex = 6;
            this.grpBoxContribuicaoMensal.TabStop = false;
            this.grpBoxContribuicaoMensal.Text = "Escolha a contribuição mensal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Outro valor";
            // 
            // txtDoarOutroValorMensal
            // 
            this.txtDoarOutroValorMensal.Location = new System.Drawing.Point(85, 55);
            this.txtDoarOutroValorMensal.Name = "txtDoarOutroValorMensal";
            this.txtDoarOutroValorMensal.Size = new System.Drawing.Size(100, 20);
            this.txtDoarOutroValorMensal.TabIndex = 14;
            this.txtDoarOutroValorMensal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoarOutroValorMensal_KeyDown);
            this.txtDoarOutroValorMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoarOutroValorMensal_KeyPress);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(245, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(51, 17);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "R$50";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(184, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(51, 17);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "R$35";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(123, 20);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(51, 17);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "R$25";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(62, 20);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(51, 17);
            this.radioButton8.TabIndex = 6;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "R$20";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 20);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(51, 17);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "R$10";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioBContribuicaoMensal
            // 
            this.radioBContribuicaoMensal.AutoSize = true;
            this.radioBContribuicaoMensal.Location = new System.Drawing.Point(226, 21);
            this.radioBContribuicaoMensal.Name = "radioBContribuicaoMensal";
            this.radioBContribuicaoMensal.Size = new System.Drawing.Size(120, 17);
            this.radioBContribuicaoMensal.TabIndex = 5;
            this.radioBContribuicaoMensal.Text = "Contribuição mensal";
            this.radioBContribuicaoMensal.UseVisualStyleBackColor = true;
            this.radioBContribuicaoMensal.CheckedChanged += new System.EventHandler(this.radioBContribuicaoMensal_CheckedChanged);
            // 
            // radioBContribuicaoUnica
            // 
            this.radioBContribuicaoUnica.AutoSize = true;
            this.radioBContribuicaoUnica.Checked = true;
            this.radioBContribuicaoUnica.Location = new System.Drawing.Point(28, 21);
            this.radioBContribuicaoUnica.Name = "radioBContribuicaoUnica";
            this.radioBContribuicaoUnica.Size = new System.Drawing.Size(113, 17);
            this.radioBContribuicaoUnica.TabIndex = 4;
            this.radioBContribuicaoUnica.TabStop = true;
            this.radioBContribuicaoUnica.Text = "Contribuição única";
            this.radioBContribuicaoUnica.UseVisualStyleBackColor = true;
            this.radioBContribuicaoUnica.CheckedChanged += new System.EventHandler(this.radioBContribuicaoUnica_CheckedChanged);
            // 
            // grpBoxContribuicaoUnica
            // 
            this.grpBoxContribuicaoUnica.Controls.Add(this.lblOutroValorUnico);
            this.grpBoxContribuicaoUnica.Controls.Add(this.txtOutroValorUnico);
            this.grpBoxContribuicaoUnica.Controls.Add(this.radioButton4);
            this.grpBoxContribuicaoUnica.Controls.Add(this.radioButton3);
            this.grpBoxContribuicaoUnica.Controls.Add(this.radioButton2);
            this.grpBoxContribuicaoUnica.Controls.Add(this.radioButton1);
            this.grpBoxContribuicaoUnica.Controls.Add(this.radioB75);
            this.grpBoxContribuicaoUnica.Location = new System.Drawing.Point(28, 58);
            this.grpBoxContribuicaoUnica.Name = "grpBoxContribuicaoUnica";
            this.grpBoxContribuicaoUnica.Size = new System.Drawing.Size(324, 101);
            this.grpBoxContribuicaoUnica.TabIndex = 2;
            this.grpBoxContribuicaoUnica.TabStop = false;
            this.grpBoxContribuicaoUnica.Text = "Escolha a contribuição única";
            // 
            // lblOutroValorUnico
            // 
            this.lblOutroValorUnico.AutoSize = true;
            this.lblOutroValorUnico.Location = new System.Drawing.Point(4, 58);
            this.lblOutroValorUnico.Name = "lblOutroValorUnico";
            this.lblOutroValorUnico.Size = new System.Drawing.Size(59, 13);
            this.lblOutroValorUnico.TabIndex = 13;
            this.lblOutroValorUnico.Text = "Outro valor";
            // 
            // txtOutroValorUnico
            // 
            this.txtOutroValorUnico.Location = new System.Drawing.Point(85, 55);
            this.txtOutroValorUnico.Name = "txtOutroValorUnico";
            this.txtOutroValorUnico.Size = new System.Drawing.Size(100, 20);
            this.txtOutroValorUnico.TabIndex = 12;
            this.txtOutroValorUnico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutroValorUnico_KeyDown);
            this.txtOutroValorUnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutroValorUnico_KeyPress);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(245, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(63, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "R$1000";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(184, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "R$500";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(123, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "R$250";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(62, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "R$125";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioB75
            // 
            this.radioB75.AutoSize = true;
            this.radioB75.Location = new System.Drawing.Point(7, 20);
            this.radioB75.Name = "radioB75";
            this.radioB75.Size = new System.Drawing.Size(51, 17);
            this.radioB75.TabIndex = 0;
            this.radioB75.TabStop = true;
            this.radioB75.Text = "R$75";
            this.radioB75.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btnLimparFiltros);
            this.grpBox.Controls.Add(this.lblStatus);
            this.grpBox.Controls.Add(this.lblModelo);
            this.grpBox.Controls.Add(this.lblTipo);
            this.grpBox.Controls.Add(this.cBoxStatus);
            this.grpBox.Controls.Add(this.cBoxModelo);
            this.grpBox.Controls.Add(this.cBoxTipo);
            this.grpBox.Location = new System.Drawing.Point(355, 27);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(574, 65);
            this.grpBox.TabIndex = 9;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Filtrar";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(343, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(174, 19);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 19);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Location = new System.Drawing.Point(342, 38);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(119, 21);
            this.cBoxStatus.TabIndex = 2;
            this.cBoxStatus.SelectedIndexChanged += new System.EventHandler(this.cBoxStatus_SelectedIndexChanged);
            // 
            // cBoxModelo
            // 
            this.cBoxModelo.FormattingEnabled = true;
            this.cBoxModelo.Location = new System.Drawing.Point(174, 38);
            this.cBoxModelo.Name = "cBoxModelo";
            this.cBoxModelo.Size = new System.Drawing.Size(119, 21);
            this.cBoxModelo.TabIndex = 1;
            this.cBoxModelo.SelectedIndexChanged += new System.EventHandler(this.cBoxModelo_SelectedIndexChanged);
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Location = new System.Drawing.Point(6, 38);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(119, 21);
            this.cBoxTipo.TabIndex = 0;
            this.cBoxTipo.SelectedIndexChanged += new System.EventHandler(this.cBoxTipo_SelectedIndexChanged);
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.AutoSize = true;
            this.btnLimparFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimparFiltros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparFiltros.Location = new System.Drawing.Point(472, 35);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(71, 23);
            this.btnLimparFiltros.TabIndex = 6;
            this.btnLimparFiltros.Text = "limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // WarSpoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnConsultarPerdas);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WarSpoting";
            this.Text = "War Spoting";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpBoxContribuicaoMensal.ResumeLayout(false);
            this.grpBoxContribuicaoMensal.PerformLayout();
            this.grpBoxContribuicaoUnica.ResumeLayout(false);
            this.grpBoxContribuicaoUnica.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnConsultarPerdas;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ComboBox cBoxTipo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.ComboBox cBoxModelo;
        private System.Windows.Forms.GroupBox grpBoxContribuicaoUnica;
        private System.Windows.Forms.RadioButton radioBContribuicaoMensal;
        private System.Windows.Forms.RadioButton radioBContribuicaoUnica;
        private System.Windows.Forms.RadioButton radioB75;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpBoxContribuicaoMensal;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label lblOutroValorUnico;
        private System.Windows.Forms.TextBox txtOutroValorUnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoarOutroValorMensal;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}