using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumFilhos_Click(object sender, EventArgs e)
        {

        }

        private void lblDados_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            double SalBruto, SalLiq, SalFami, NumFilho, AliqINSS ,AliqIRPF ;


            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                MessageBox.Show("Nome não pode estar em branco!");
            else
                if (double.TryParse(mskbxSalBruto.Text, out SalBruto) && double.TryParse(mskbxNumFilhos.Text, out NumFilho))

                if (RbtnF.Checked == true || RbtnM.Checked == true)
                {
                    string nome;
                    nome = txtNomeFunc.Text;


                    if (RbtnF.Checked == true && ckbxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\n que é casada\n e tem {1} fiho(s)", nome, NumFilho);
                    if (RbtnF.Checked == true && ckbxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário da Sra.{0}\n que é solteira\n e tem {1} filho(s)", nome, NumFilho);
                    if (RbtnF.Checked == false && ckbxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário do Sr.{0}\n que é casado \n e tem {1} filho(s)", nome, NumFilho);
                    if (RbtnF.Checked == false && ckbxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário do Sr.{0}\n que é solteiro \n e tem {1} filho(s)", nome, NumFilho);

                    if (SalBruto <= 800.47)
                    {
                        AliqINSS = SalBruto * (7.65 / 100);
                        mskbxINSS.Text = "7.65%";
                    }
                    else if (SalBruto <= 1050)
                    {
                        AliqINSS = SalBruto * (8.65 / 100);
                        mskbxINSS.Text = "8.65%";
                    }
                    else if (SalBruto <= 1400.77)
                    {
                        AliqINSS = SalBruto * (9 / 100);
                        mskbxINSS.Text = "9.00%";
                    }
                    else if (SalBruto <= 2801.56)
                    {
                        AliqINSS = SalBruto * (11 / 100);
                        mskbxINSS.Text = "11%";
                    }
                    else
                    {
                        AliqINSS = 308.17;
                        mskbxINSS.Text = "Teto";
                    }

                    mskbxDescINSS.Text = AliqINSS.ToString("N2");


                    if (SalBruto <= 1257.12)
                    {
                        AliqIRPF = 0;
                        mskbxIRPF.Text = "0";
                    }
                    else if (SalBruto <= 2512.18)
                    {
                        AliqIRPF = SalBruto * (15 / 100);
                        mskbxIRPF.Text = "15%";
                    }
                    else
                    {
                        AliqIRPF = SalBruto * (27.5 / 100);
                        mskbxIRPF.Text = "27.5%";
                    }

                    mskbxDescIRPF.Text = AliqIRPF.ToString("N2");


                    if (SalBruto <= 435.52)
                    {
                        SalFami = NumFilho * 22.33;
                    }
                    else if (SalBruto <= 654.61)
                        SalFami = NumFilho * 15.74;
                    else
                        SalFami = 0;


                    mskbxSalFamilia.Text = SalFami.ToString("N2");

                    SalLiq = SalBruto - AliqINSS - AliqIRPF + SalFami;
                    mskbxSalLiq.Text = SalLiq.ToString("N2");






                }

                else
                    MessageBox.Show("Selecione um Sexo!");

            else
                MessageBox.Show("Dados Inválidos!");
        }

        private void mskbxSalBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}