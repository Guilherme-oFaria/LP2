
namespace Peso_Ideal
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.textBoxPesat = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblPesAtu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(354, 221);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(335, 150);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(73, 17);
            this.radioButtonM.TabIndex = 3;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Masculino";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(414, 150);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(67, 17);
            this.radioButtonF.TabIndex = 4;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Feminino";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // textBoxPesat
            // 
            this.textBoxPesat.Location = new System.Drawing.Point(335, 102);
            this.textBoxPesat.Name = "textBoxPesat";
            this.textBoxPesat.Size = new System.Drawing.Size(60, 20);
            this.textBoxPesat.TabIndex = 1;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(455, 102);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(48, 20);
            this.textBoxAltura.TabIndex = 2;
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(409, 105);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(40, 13);
            this.lblAlt.TabIndex = 10;
            this.lblAlt.Text = "Altura :";
            // 
            // lblPesAtu
            // 
            this.lblPesAtu.AutoSize = true;
            this.lblPesAtu.Location = new System.Drawing.Point(271, 105);
            this.lblPesAtu.Name = "lblPesAtu";
            this.lblPesAtu.Size = new System.Drawing.Size(64, 13);
            this.lblPesAtu.TabIndex = 6;
            this.lblPesAtu.Text = "Peso Atual :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculando Peso Ideal";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(295, 152);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sexo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblPesAtu);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxPesat);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.TextBox textBoxPesat;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblPesAtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSex;
    }
}

