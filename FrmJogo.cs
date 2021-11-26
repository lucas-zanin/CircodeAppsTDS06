using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApp3
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

        private void cbxOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcao = cbxOpcao.SelectedIndex;
            switch (opcao)
            {
                case 0:
                    pbxOpcao.Image = Properties.Resources.papel;
                    break;
                case 1:
                    pbxOpcao.Image = Properties.Resources.pedra;
                    break;
                case 2:
                    pbxOpcao.Image = Properties.Resources.tesoura;
                    break;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Random randonum = new Random();
            int sorteio = Convert.ToInt32(randonum.Next(3));
            label1.Text = Convert.ToString(sorteio);
        }
    }
}
