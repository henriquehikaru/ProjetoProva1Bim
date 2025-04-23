namespace ProjetoProva1Bim
{
    partial class frmMedia
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
            this.numN1 = new System.Windows.Forms.NumericUpDown();
            this.numN2 = new System.Windows.Forms.NumericUpDown();
            this.numN3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN3)).BeginInit();
            this.SuspendLayout();
            // 
            // numN1
            // 
            this.numN1.DecimalPlaces = 1;
            this.numN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numN1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numN1.Location = new System.Drawing.Point(153, 61);
            this.numN1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numN1.Name = "numN1";
            this.numN1.Size = new System.Drawing.Size(120, 26);
            this.numN1.TabIndex = 0;
            this.numN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numN1.Enter += new System.EventHandler(this.numN1_Enter);
            this.numN1.Leave += new System.EventHandler(this.numN1_Leave);
            // 
            // numN2
            // 
            this.numN2.DecimalPlaces = 1;
            this.numN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numN2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numN2.Location = new System.Drawing.Point(153, 107);
            this.numN2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numN2.Name = "numN2";
            this.numN2.Size = new System.Drawing.Size(120, 26);
            this.numN2.TabIndex = 1;
            this.numN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numN2.Enter += new System.EventHandler(this.numN2_Enter);
            this.numN2.Leave += new System.EventHandler(this.numN2_Leave);
            // 
            // numN3
            // 
            this.numN3.DecimalPlaces = 1;
            this.numN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numN3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numN3.Location = new System.Drawing.Point(153, 152);
            this.numN3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numN3.Name = "numN3";
            this.numN3.Size = new System.Drawing.Size(120, 26);
            this.numN3.TabIndex = 2;
            this.numN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numN3.Enter += new System.EventHandler(this.numN3_Enter);
            this.numN3.Leave += new System.EventHandler(this.numN3_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Média:";
            // 
            // lblMedia
            // 
            this.lblMedia.BackColor = System.Drawing.Color.Bisque;
            this.lblMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(153, 201);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(120, 32);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(51, 294);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(153, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 30);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(256, 294);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 359);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numN3);
            this.Controls.Add(this.numN2);
            this.Controls.Add(this.numN1);
            this.Name = "frmMedia";
            this.Text = "Media";
            ((System.ComponentModel.ISupportInitialize)(this.numN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numN1;
        private System.Windows.Forms.NumericUpDown numN2;
        private System.Windows.Forms.NumericUpDown numN3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}