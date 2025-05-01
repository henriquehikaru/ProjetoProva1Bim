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
    public partial class frmTemperatura : Form
    {
        decimal temperaturaCelsius;
        public frmTemperatura()
        {
            
            InitializeComponent();
        }

        private decimal AcrescimoPercentual(decimal temperatura, decimal percentual)
        {
            // Calcula o acréscimo percentual na temperatura
            decimal resultado = temperatura + (temperatura * percentual / 100);
            lblResultado.Text = resultado.ToString("0.0") + " °C";
            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtTemp.Text == String.Empty)
            {
                MessageBox.Show("Campo temperatura não pode ser vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemp.Focus();
                return;
            }

            if (numPercAc.Value == 0)
            {
                MessageBox.Show("Campo percentual não pode ser zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPercAc.Focus();
                return;
            }

            temperaturaCelsius = Convert.ToDecimal(txtTemp.Text);
            AcrescimoPercentual(temperaturaCelsius, numPercAc.Value);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblResultado.Text = String.Empty;
            txtTemp.Clear();
            numPercAc.Value = 0;
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

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
    }
}
