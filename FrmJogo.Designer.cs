
namespace CircodeApp3
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.cbxOpcao = new System.Windows.Forms.ComboBox();
            this.pbxOpcao = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbxJogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(220, 23);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(12, 9);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(129, 13);
            this.lblOpcao.TabIndex = 1;
            this.lblOpcao.Text = "Selecione uma opção";
            // 
            // cbxOpcao
            // 
            this.cbxOpcao.FormattingEnabled = true;
            this.cbxOpcao.Items.AddRange(new object[] {
            "Papel",
            "Pedra",
            "Tesoura"});
            this.cbxOpcao.Location = new System.Drawing.Point(12, 25);
            this.cbxOpcao.Name = "cbxOpcao";
            this.cbxOpcao.Size = new System.Drawing.Size(177, 21);
            this.cbxOpcao.TabIndex = 2;
            this.cbxOpcao.SelectedIndexChanged += new System.EventHandler(this.cbxOpcao_SelectedIndexChanged);
            // 
            // pbxOpcao
            // 
            this.pbxOpcao.Image = global::CircodeApp3.Properties.Resources.pedrapapeltesoura1;
            this.pbxOpcao.Location = new System.Drawing.Point(12, 64);
            this.pbxOpcao.Name = "pbxOpcao";
            this.pbxOpcao.Size = new System.Drawing.Size(177, 191);
            this.pbxOpcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOpcao.TabIndex = 3;
            this.pbxOpcao.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(312, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbxJogo
            // 
            this.pbxJogo.Image = global::CircodeApp3.Properties.Resources.pedrapapeltesoura1;
            this.pbxJogo.Location = new System.Drawing.Point(210, 64);
            this.pbxJogo.Name = "pbxJogo";
            this.pbxJogo.Size = new System.Drawing.Size(177, 191);
            this.pbxJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJogo.TabIndex = 5;
            this.pbxJogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxJogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pbxOpcao);
            this.Controls.Add(this.cbxOpcao);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.btnJogar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra - Papel - Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.ComboBox cbxOpcao;
        private System.Windows.Forms.PictureBox pbxOpcao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbxJogo;
        private System.Windows.Forms.Label label1;
    }
}