using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1, num2, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxN1.Text, out num1) && double.TryParse(textBoxN2.Text, out num2))
            {
                res = num1 - num2;
                textBoxRes.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Dados Inválidos!", "Erro");
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxN1.Text, out num1) && double.TryParse(textBoxN2.Text, out num2))
            {
                res = num1 * num2;
                textBoxRes.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Dados Inválidos!", "Erro");
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxN1.Text, out num1) && double.TryParse(textBoxN2.Text, out num2))
            {
                res = num1 / num2;
                textBoxRes.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Dados Inválidos!", "Erro");
            }

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textBoxN1.Text = ""; textBoxN2.Text = ""; textBoxRes.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxN1.Text, out num1) && double.TryParse(textBoxN2.Text, out num2))
            {
                res = num1 + num2;
                textBoxRes.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Dados Inválidos!", "Erro");
            }




        }
    }
}