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
            this.tabDetalhes = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.tabLocalizacao = new System.Windows.Forms.TabPage();
            this.tabPatrocinar = new System.Windows.Forms.TabPage();
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
            this.grpBoxContribuicaoMensal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoarOutroValorMensal = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.cBoxModelo = new System.Windows.Forms.ComboBox();
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDetalhes.SuspendLayout();
            this.tabLocalizacao.SuspendLayout();
            this.tabPatrocinar.SuspendLayout();
            this.grpBoxContribuicaoUnica.SuspendLayout();
            this.grpBoxContribuicaoMensal.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(10, 80);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(18, 464);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1221, 84);
            this.listBox.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(18, 555);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1221, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnConsultarPerdas
            // 
            this.btnConsultarPerdas.AutoSize = true;
            this.btnConsultarPerdas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarPerdas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultarPerdas.Location = new System.Drawing.Point(325, 80);
            this.btnConsultarPerdas.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarPerdas.Name = "btnConsultarPerdas";
            this.btnConsultarPerdas.Size = new System.Drawing.Size(123, 25);
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1267, 24);
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
            this.lblData.Location = new System.Drawing.Point(10, 56);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(127, 16);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Selecione uma data";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabDetalhes);
            this.tabControl.Controls.Add(this.tabLocalizacao);
            this.tabControl.Controls.Add(this.tabPatrocinar);
            this.tabControl.Location = new System.Drawing.Point(10, 129);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1237, 333);
            this.tabControl.TabIndex = 8;
            // 
            // tabDetalhes
            // 
            this.tabDetalhes.Controls.Add(this.listView);
            this.tabDetalhes.Location = new System.Drawing.Point(4, 25);
            this.tabDetalhes.Margin = new System.Windows.Forms.Padding(4);
            this.tabDetalhes.Name = "tabDetalhes";
            this.tabDetalhes.Padding = new System.Windows.Forms.Padding(4);
            this.tabDetalhes.Size = new System.Drawing.Size(1229, 304);
            this.tabDetalhes.TabIndex = 0;
            this.tabDetalhes.Text = "Detalhes";
            this.tabDetalhes.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(4, 4);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1221, 296);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // tabLocalizacao
            // 
            this.tabLocalizacao.Location = new System.Drawing.Point(4, 25);
            this.tabLocalizacao.Margin = new System.Windows.Forms.Padding(4);
            this.tabLocalizacao.Name = "tabLocalizacao";
            this.tabLocalizacao.Padding = new System.Windows.Forms.Padding(4);
            this.tabLocalizacao.Size = new System.Drawing.Size(1229, 304);
            this.tabLocalizacao.TabIndex = 1;
            this.tabLocalizacao.Text = "Localização";
            this.tabLocalizacao.UseVisualStyleBackColor = true;
            // 
            // tabPatrocinar
            // 
            this.tabPatrocinar.Controls.Add(this.radioBContribuicaoMensal);
            this.tabPatrocinar.Controls.Add(this.radioBContribuicaoUnica);
            this.tabPatrocinar.Controls.Add(this.grpBoxContribuicaoUnica);
            this.tabPatrocinar.Controls.Add(this.grpBoxContribuicaoMensal);
            this.tabPatrocinar.Location = new System.Drawing.Point(4, 25);
            this.tabPatrocinar.Margin = new System.Windows.Forms.Padding(4);
            this.tabPatrocinar.Name = "tabPatrocinar";
            this.tabPatrocinar.Size = new System.Drawing.Size(1229, 304);
            this.tabPatrocinar.TabIndex = 2;
            this.tabPatrocinar.Text = "Patrocinar";
            this.tabPatrocinar.UseVisualStyleBackColor = true;
            // 
            // radioBContribuicaoMensal
            // 
            this.radioBContribuicaoMensal.AutoSize = true;
            this.radioBContribuicaoMensal.Location = new System.Drawing.Point(301, 26);
            this.radioBContribuicaoMensal.Margin = new System.Windows.Forms.Padding(4);
            this.radioBContribuicaoMensal.Name = "radioBContribuicaoMensal";
            this.radioBContribuicaoMensal.Size = new System.Drawing.Size(147, 20);
            this.radioBContribuicaoMensal.TabIndex = 5;
            this.radioBContribuicaoMensal.Text = "Contribuição mensal";
            this.radioBContribuicaoMensal.UseVisualStyleBackColor = true;
            this.radioBContribuicaoMensal.CheckedChanged += new System.EventHandler(this.radioBContribuicaoMensal_CheckedChanged);
            // 
            // radioBContribuicaoUnica
            // 
            this.radioBContribuicaoUnica.AutoSize = true;
            this.radioBContribuicaoUnica.Checked = true;
            this.radioBContribuicaoUnica.Location = new System.Drawing.Point(37, 26);
            this.radioBContribuicaoUnica.Margin = new System.Windows.Forms.Padding(4);
            this.radioBContribuicaoUnica.Name = "radioBContribuicaoUnica";
            this.radioBContribuicaoUnica.Size = new System.Drawing.Size(135, 20);
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
            this.grpBoxContribuicaoUnica.Location = new System.Drawing.Point(37, 71);
            this.grpBoxContribuicaoUnica.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxContribuicaoUnica.Name = "grpBoxContribuicaoUnica";
            this.grpBoxContribuicaoUnica.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxContribuicaoUnica.Size = new System.Drawing.Size(432, 124);
            this.grpBoxContribuicaoUnica.TabIndex = 2;
            this.grpBoxContribuicaoUnica.TabStop = false;
            this.grpBoxContribuicaoUnica.Text = "Escolha a contribuição única";
            // 
            // lblOutroValorUnico
            // 
            this.lblOutroValorUnico.AutoSize = true;
            this.lblOutroValorUnico.Location = new System.Drawing.Point(5, 71);
            this.lblOutroValorUnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutroValorUnico.Name = "lblOutroValorUnico";
            this.lblOutroValorUnico.Size = new System.Drawing.Size(72, 16);
            this.lblOutroValorUnico.TabIndex = 13;
            this.lblOutroValorUnico.Text = "Outro valor";
            // 
            // txtOutroValorUnico
            // 
            this.txtOutroValorUnico.Location = new System.Drawing.Point(113, 68);
            this.txtOutroValorUnico.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutroValorUnico.Name = "txtOutroValorUnico";
            this.txtOutroValorUnico.Size = new System.Drawing.Size(132, 22);
            this.txtOutroValorUnico.TabIndex = 12;
            this.txtOutroValorUnico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutroValorUnico_KeyDown);
            this.txtOutroValorUnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutroValorUnico_KeyPress);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(327, 25);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 20);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "R$1000";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(245, 25);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "R$500";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(164, 25);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "R$250";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(83, 25);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "R$125";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioB75
            // 
            this.radioB75.AutoSize = true;
            this.radioB75.Location = new System.Drawing.Point(9, 25);
            this.radioB75.Margin = new System.Windows.Forms.Padding(4);
            this.radioB75.Name = "radioB75";
            this.radioB75.Size = new System.Drawing.Size(56, 20);
            this.radioB75.TabIndex = 0;
            this.radioB75.TabStop = true;
            this.radioB75.Text = "R$75";
            this.radioB75.UseVisualStyleBackColor = true;
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
            this.grpBoxContribuicaoMensal.Location = new System.Drawing.Point(37, 71);
            this.grpBoxContribuicaoMensal.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxContribuicaoMensal.Name = "grpBoxContribuicaoMensal";
            this.grpBoxContribuicaoMensal.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxContribuicaoMensal.Size = new System.Drawing.Size(432, 124);
            this.grpBoxContribuicaoMensal.TabIndex = 6;
            this.grpBoxContribuicaoMensal.TabStop = false;
            this.grpBoxContribuicaoMensal.Text = "Escolha a contribuição mensal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Outro valor";
            // 
            // txtDoarOutroValorMensal
            // 
            this.txtDoarOutroValorMensal.Location = new System.Drawing.Point(113, 68);
            this.txtDoarOutroValorMensal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoarOutroValorMensal.Name = "txtDoarOutroValorMensal";
            this.txtDoarOutroValorMensal.Size = new System.Drawing.Size(132, 22);
            this.txtDoarOutroValorMensal.TabIndex = 14;
            this.txtDoarOutroValorMensal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoarOutroValorMensal_KeyDown);
            this.txtDoarOutroValorMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoarOutroValorMensal_KeyPress);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(327, 25);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 20);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "R$50";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(245, 25);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(56, 20);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "R$35";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(164, 25);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(56, 20);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "R$25";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(83, 25);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(56, 20);
            this.radioButton8.TabIndex = 6;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "R$20";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(9, 25);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(56, 20);
            this.radioButton9.TabIndex = 5;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "R$10";
            this.radioButton9.UseVisualStyleBackColor = true;
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
            this.grpBox.Location = new System.Drawing.Point(473, 33);
            this.grpBox.Margin = new System.Windows.Forms.Padding(4);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(4);
            this.grpBox.Size = new System.Drawing.Size(765, 80);
            this.grpBox.TabIndex = 9;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Filtrar";
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.AutoSize = true;
            this.btnLimparFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimparFiltros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparFiltros.Location = new System.Drawing.Point(629, 43);
            this.btnLimparFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(88, 26);
            this.btnLimparFiltros.TabIndex = 6;
            this.btnLimparFiltros.Text = "limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(457, 23);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(232, 23);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(53, 16);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 23);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Location = new System.Drawing.Point(456, 47);
            this.cBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(157, 24);
            this.cBoxStatus.TabIndex = 2;
            this.cBoxStatus.SelectedIndexChanged += new System.EventHandler(this.cBoxStatus_SelectedIndexChanged);
            // 
            // cBoxModelo
            // 
            this.cBoxModelo.FormattingEnabled = true;
            this.cBoxModelo.Location = new System.Drawing.Point(232, 47);
            this.cBoxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxModelo.Name = "cBoxModelo";
            this.cBoxModelo.Size = new System.Drawing.Size(157, 24);
            this.cBoxModelo.TabIndex = 1;
            this.cBoxModelo.SelectedIndexChanged += new System.EventHandler(this.cBoxModelo_SelectedIndexChanged);
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Location = new System.Drawing.Point(8, 47);
            this.cBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(157, 24);
            this.cBoxTipo.TabIndex = 0;
            this.cBoxTipo.SelectedIndexChanged += new System.EventHandler(this.cBoxTipo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1267, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // WarSpoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 608);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnConsultarPerdas);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WarSpoting";
            this.Text = "War Spoting";
            this.Load += new System.EventHandler(this.WarSpoting_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDetalhes.ResumeLayout(false);
            this.tabLocalizacao.ResumeLayout(false);
            this.tabPatrocinar.ResumeLayout(false);
            this.tabPatrocinar.PerformLayout();
            this.grpBoxContribuicaoUnica.ResumeLayout(false);
            this.grpBoxContribuicaoUnica.PerformLayout();
            this.grpBoxContribuicaoMensal.ResumeLayout(false);
            this.grpBoxContribuicaoMensal.PerformLayout();
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
        private System.Windows.Forms.TabPage tabDetalhes;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TabPage tabLocalizacao;
        private System.Windows.Forms.TabPage tabPatrocinar;
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