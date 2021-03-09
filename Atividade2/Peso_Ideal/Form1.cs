using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Ideal
{
    public partial class Form1 : Form
    {
        double pesat, alt, peside;
        string sexo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPesat.Text, out pesat) && double.TryParse(textBoxAltura.Text, out alt))
            {
                if (radioButtonM.Checked)
                {

                    peside = (72.7 * alt) - 58;
                    if (pesat < peside)
                    {
                        MessageBox.Show("Seu peso ideal é de: " + peside + " Kg.", "aviso");
                        MessageBox.Show("Você está abaixo do peso!", "alerta");
                    }
                    if (pesat == peside)
                    {
                        MessageBox.Show("Seu peso ideal é de: " + peside + " Kg.", "aviso");
                        MessageBox.Show("Você está em seu peso ideal!", "aviso");
                    }
                    if (pesat > peside)
                    {
                        MessageBox.Show("Seu peso ideal é de: " + peside + " Kg.", "aviso");
                        MessageBox.Show("Você está acima do peso!", "alerta");
                        MessageBox.Show("Test");
                    }
                }
                if  (radioButtonF.Checked)           
                {
                    peside = (72.7 * alt) - 58;
                    if (pesat < peside)
                    {
                        MessageBox.Show("Seu peso ideal é de: " + peside + " Kg.", "aviso");
                        MessageBox.Show("Você está abaixo do peso!", "alerta");
                    }
                    if (peside == pesat)
                    {
                        MessageBox.Show("Seu peso ideal é de: " + peside + " Kg.", "aviso");
                        MessageBox.Show("Você está em seu peso ideal!", "aviso");
                    }
                    else
                    {
                        MessageBox.Show("Seu peso ideal é de: " + peside + " Kg.", "aviso");
                        MessageBox.Show("Você está acima do peso!", "alerta");
                    }
                }   
            }
            else
            {
                MessageBox.Show("nfoi!");
            }
        }   

    }
}
