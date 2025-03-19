
namespace tati_thiago_dos_santos_p1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGET
            // 
            this.btnGET.Location = new System.Drawing.Point(197, 86);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(75, 23);
            this.btnGET.TabIndex = 0;
            this.btnGET.Text = "button1";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGET);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGET;
    }
}

