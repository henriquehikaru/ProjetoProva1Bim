namespace ProjetoProva1Bim
{
    partial class frmTemperatura
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPercAc = new System.Windows.Forms.NumericUpDown();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPercAc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(74, 72);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 26);
            this.txtTemp.TabIndex = 0;
            this.txtTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Percentual acréscimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            // 
            // numPercAc
            // 
            this.numPercAc.DecimalPlaces = 2;
            this.numPercAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPercAc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPercAc.Location = new System.Drawing.Point(299, 72);
            this.numPercAc.Name = "numPercAc";
            this.numPercAc.Size = new System.Drawing.Size(120, 26);
            this.numPercAc.TabIndex = 5;
            this.numPercAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(153, 142);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(181, 46);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(74, 239);
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
            this.btnCalcular.Location = new System.Drawing.Point(209, 239);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(344, 239);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 328);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.numPercAc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Name = "frmTemperatura";
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.numPercAc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPercAc;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

