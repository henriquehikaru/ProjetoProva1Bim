using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProva1Bim
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        double CalcularMedia(double a, double b, double c)
        {
            double m = (a + b + c) / 3;
            return m;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (numN1.Value == 0 || numN2.Value == 0 || numN3.Value == 0)
            {
                MessageBox.Show("Os campos não podem ficar vazios!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double n1, n2, n3;
            n1 = (double)numN1.Value;
            n2 = (double)numN2.Value;
            n3 = (double)numN3.Value;
            lblMedia.Text = CalcularMedia(n1, n2, n3).ToString("0.0");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            numN1.Value = 0;
            numN2.Value = 0;
            numN3.Value = 0;
            lblMedia.Text = String.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                return;
            }
            frmTemperatura.ActiveForm.Close();
        }

        private void numN1_Enter(object sender, EventArgs e)
        {
            numN1.BackColor = Color.LightSalmon;
            numN1.Select(0, numN1.Value.ToString("#0.0").Length);
        }

        private void numN2_Enter(object sender, EventArgs e)
        {
            numN2.BackColor = Color.LightSalmon;
            numN2.Select(0, numN2.Value.ToString("#0.0").Length);
        }

        private void numN3_Enter(object sender, EventArgs e)
        {
            numN3.BackColor = Color.LightSalmon;
            numN3.Select(0, numN3.Value.ToString("#0.0").Length);
        }

        private void numN1_Leave(object sender, EventArgs e)
        {
            numN1.BackColor = Color.White;
        }

        private void numN2_Leave(object sender, EventArgs e)
        {
            numN2.BackColor = Color.White;
        }

        private void numN3_Leave(object sender, EventArgs e)
        {
            numN3.BackColor = Color.White;
        }
    }
}
