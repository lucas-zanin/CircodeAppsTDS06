
namespace CircodeApp3
{
    partial class FrmPrincipal
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
            this.lblBuscaCEP = new System.Windows.Forms.Label();
            this.pbxCEP = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscaCEP
            // 
            this.lblBuscaCEP.AutoSize = true;
            this.lblBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCEP.Location = new System.Drawing.Point(41, 146);
            this.lblBuscaCEP.Name = "lblBuscaCEP";
            this.lblBuscaCEP.Size = new System.Drawing.Size(85, 16);
            this.lblBuscaCEP.TabIndex = 0;
            this.lblBuscaCEP.Text = "Busca CEP";
            // 
            // pbxCEP
            // 
            this.pbxCEP.Image = global::CircodeApp3.Properties.Resources.cep;
            this.pbxCEP.Location = new System.Drawing.Point(22, 12);
            this.pbxCEP.Name = "pbxCEP";
            this.pbxCEP.Size = new System.Drawing.Size(128, 131);
            this.pbxCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCEP.TabIndex = 1;
            this.pbxCEP.TabStop = false;
            this.pbxCEP.Click += new System.EventHandler(this.pbxCEP_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(507, 291);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 34);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 337);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pbxCEP);
            this.Controls.Add(this.lblBuscaCEP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps TDS06";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscaCEP;
        private System.Windows.Forms.PictureBox pbxCEP;
        private System.Windows.Forms.Button btnSair;
    }
}

