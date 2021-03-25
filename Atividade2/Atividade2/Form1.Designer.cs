
namespace Atividade2
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(201, 116);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(59, 35);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 1;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(242, 113);
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(100, 20);
            this.mskbxAltura.TabIndex = 2;
            // 
            // mskbxPesoAtual
            // 
            this.mskbxPesoAtual.Location = new System.Drawing.Point(242, 161);
            this.mskbxPesoAtual.Name = "mskbxPesoAtual";
            this.mskbxPesoAtual.Size = new System.Drawing.Size(100, 20);
            this.mskbxPesoAtual.TabIndex = 3;
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Location = new System.Drawing.Point(201, 162);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(34, 13);
            this.lblPesoAtual.TabIndex = 4;
            this.lblPesoAtual.Text = "Peso:";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFem);
            this.gbSexo.Controls.Add(this.rbMasc);
            this.gbSexo.Location = new System.Drawing.Point(425, 99);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 100);
            this.gbSexo.TabIndex = 5;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(59, 58);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(67, 17);
            this.rbFem.TabIndex = 2;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(254, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.mskbxPesoAtual);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.MaskedTextBox mskbxPesoAtual;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.Button btnCalcular;
    }
}

