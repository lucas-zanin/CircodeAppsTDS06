using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace CircodeApp3
{
    public partial class FrmBuscaCEP : Form
    {
        public FrmBuscaCEP()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/"+txtCep.Text+"/json");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor Indisponível!");
                return; //Sai da rotina e para e codificação
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado!");
                                    txtCep.Focus();
                                    return;
                                }
                            }

                            //Endereço
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblEndereco.Text = valor[1];
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblComplemento.Text = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblBairro.Text = valor[1];
                            }

                            //Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblCidade.Text = valor[1];
                            }

                            //UF
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblUF.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }
        }
    }
}
