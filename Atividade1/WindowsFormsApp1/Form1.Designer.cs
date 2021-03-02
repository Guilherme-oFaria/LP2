
namespace WindowsFormsApp1
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(201, 331);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(66, 32);
            this.btnSoma.TabIndex = 3;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(296, 331);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(66, 32);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(391, 331);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(66, 32);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "*";
            this.btnMult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(481, 331);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(66, 32);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(629, 151);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(629, 208);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(209, 110);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(60, 13);
            this.lblN1.TabIndex = 9;
            this.lblN1.Text = "1° Número:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(209, 176);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(60, 13);
            this.lblN2.TabIndex = 10;
            this.lblN2.Text = "2° Número:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(209, 243);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(58, 13);
            this.lblRes.TabIndex = 11;
            this.lblRes.Text = "Resultado:";
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(296, 107);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(217, 20);
            this.textBoxN1.TabIndex = 12;
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(296, 173);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(217, 20);
            this.textBoxN2.TabIndex = 13;
            // 
            // textBoxRes
            // 
            this.textBoxRes.Enabled = false;
            this.textBoxRes.Location = new System.Drawing.Point(296, 240);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(217, 20);
            this.textBoxRes.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Label label1;
    }
}

