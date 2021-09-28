
namespace Trabalho_POO
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
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLado1.Location = new System.Drawing.Point(26, 9);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(58, 20);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLado2.Location = new System.Drawing.Point(26, 58);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(58, 20);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLado3.Location = new System.Drawing.Point(26, 104);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(58, 20);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "Lado 3";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(68, 212);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(68, 17);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "Resposta";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(30, 32);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(176, 20);
            this.txtLado1.TabIndex = 4;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(30, 81);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(176, 20);
            this.txtLado2.TabIndex = 5;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(30, 127);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(176, 20);
            this.txtLado3.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Black;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(30, 162);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(176, 34);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Calcular Lados";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 292);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Name = "Form1";
            this.Text = "Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnVerificar;
    }
}

