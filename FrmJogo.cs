using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeAppsTDS06
{
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxJogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcao = cbxJogo.SelectedIndex;
            switch (opcao)
            {
                case 0:
                    pbxJogador.Image = Properties.Resources.papel;
                    break;
                case 1:
                    pbxJogador.Image = Properties.Resources.pedra;
                    break;
                case 2:
                    pbxJogador.Image = Properties.Resources.tesoura;
                    break;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int opcao = cbxJogo.SelectedIndex;
            Random randonum = new Random();
            int sorteio = Convert.ToInt32(randonum.Next(3));
            switch (sorteio)
            {
                case 0:
                    pbxComputador.Image = Properties.Resources.papel;
                    break;
                case 1:
                    pbxComputador.Image = Properties.Resources.pedra;
                    break;
                case 2:
                    pbxComputador.Image = Properties.Resources.tesoura;
                    break;
            }
            if (opcao == sorteio)
            {
                MessageBox.Show("Empatou");
            }
            else if (opcao == 0 && sorteio == 1 || opcao == 1 && sorteio == 2 || opcao == 2 && sorteio == 0)
            {
                MessageBox.Show("Ganhou");
            }
            else
            {
                MessageBox.Show("Perdeu");
            }
        }
    }
}
