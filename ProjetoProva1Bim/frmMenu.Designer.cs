namespace ProjetoProva1Bim
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMedia.Image = global::ProjetoProva1Bim.Properties.Resources.school_outline_256x222;
            this.btnMedia.Location = new System.Drawing.Point(458, 208);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(300, 300);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "&m";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemperatura.Image = global::ProjetoProva1Bim.Properties.Resources.temperature_max_256x256;
            this.btnTemperatura.Location = new System.Drawing.Point(30, 208);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(300, 300);
            this.btnTemperatura.TabIndex = 0;
            this.btnTemperatura.Text = "&t";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem-vindo! Selecione uma Ferramenta:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(38, 155);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(285, 50);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Acréscimo de Temperatura (%)\r\n\r\n";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(470, 155);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(273, 25);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Calculadora de Média Escolar";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 541);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnTemperatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblMedia;
    }
}