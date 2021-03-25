using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double PesoAtual, Altura, PesoIdeal;
           
            if (double.TryParse(mskbxAltura.Text, out Altura) & (double.TryParse(mskbxPesoAtual.Text, out PesoAtual)))
            {
                if (rbMasc.Checked == true)
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                }
                else
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                }
                if (PesoAtual > PesoIdeal)
                {
                    MessageBox.Show("Regime Obrigatório já", "Alerta");
                }
                else if (PesoAtual < PesoIdeal)
                {
                    MessageBox.Show("Comer bastante massas e doces!", "Alerta");
                }
                else
                {
                    MessageBox.Show("Você está em seu peso ideal!", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }
    }
}
