
namespace CircodeAppsTDS06
{
    partial class FrmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelecao = new System.Windows.Forms.Label();
            this.cbxJogo = new System.Windows.Forms.ComboBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.pbxJogador = new System.Windows.Forms.PictureBox();
            this.pbxComputador = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblComputador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Location = new System.Drawing.Point(13, 13);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(93, 13);
            this.lblSelecao.TabIndex = 0;
            this.lblSelecao.Text = "Selecione um item";
            // 
            // cbxJogo
            // 
            this.cbxJogo.FormattingEnabled = true;
            this.cbxJogo.Items.AddRange(new object[] {
            "Papel",
            "Pedra",
            "Tesoura"});
            this.cbxJogo.Location = new System.Drawing.Point(13, 30);
            this.cbxJogo.Name = "cbxJogo";
            this.cbxJogo.Size = new System.Drawing.Size(160, 21);
            this.cbxJogo.TabIndex = 1;
            this.cbxJogo.SelectedIndexChanged += new System.EventHandler(this.cbxJogo_SelectedIndexChanged);
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(194, 30);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // pbxJogador
            // 
            this.pbxJogador.Image = global::CircodeAppsTDS06.Properties.Resources.pedrapapeltesoura;
            this.pbxJogador.Location = new System.Drawing.Point(16, 108);
            this.pbxJogador.Name = "pbxJogador";
            this.pbxJogador.Size = new System.Drawing.Size(157, 163);
            this.pbxJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJogador.TabIndex = 3;
            this.pbxJogador.TabStop = false;
            // 
            // pbxComputador
            // 
            this.pbxComputador.Image = global::CircodeAppsTDS06.Properties.Resources.pedrapapeltesoura;
            this.pbxComputador.Location = new System.Drawing.Point(194, 108);
            this.pbxComputador.Name = "pbxComputador";
            this.pbxComputador.Size = new System.Drawing.Size(157, 163);
            this.pbxComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComputador.TabIndex = 4;
            this.pbxComputador.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(276, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(13, 92);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(52, 13);
            this.lblJogador.TabIndex = 6;
            this.lblJogador.Text = "Jogador";
            // 
            // lblComputador
            // 
            this.lblComputador.AutoSize = true;
            this.lblComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputador.Location = new System.Drawing.Point(191, 92);
            this.lblComputador.Name = "lblComputador";
            this.lblComputador.Size = new System.Drawing.Size(74, 13);
            this.lblComputador.TabIndex = 7;
            this.lblComputador.Text = "Computador";
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 284);
            this.Controls.Add(this.lblComputador);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pbxComputador);
            this.Controls.Add(this.pbxJogador);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.cbxJogo);
            this.Controls.Add(this.lblSelecao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra - Papel - Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.ComboBox cbxJogo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.PictureBox pbxJogador;
        private System.Windows.Forms.PictureBox pbxComputador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblComputador;
    }
}