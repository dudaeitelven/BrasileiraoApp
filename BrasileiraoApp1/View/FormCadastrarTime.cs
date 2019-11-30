using BrasileiraoApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiraoApp.View
{
    public partial class FormCadastrarTime : Form
    {
        public FormCadastrarTime()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            CadastrarTime cadastrarTime = new CadastrarTime();
            TIME time = new TIME(
                                textBoxNome.Text, 
                                textBoxHistoria.Text,
                                ((textBoxAnoFundacao.Text != "") ? (Convert.ToInt32(textBoxAnoFundacao.Text)):(0)),
                                ((textBoxQtdeTorcedores.Text != "") ? (Convert.ToInt32(textBoxQtdeTorcedores.Text)) : (0)),
                                ((textBoxQtdeTitulos.Text != "") ? (Convert.ToInt32(textBoxQtdeTitulos.Text)) : (0))
                                );
            cadastrarTime.SalvarTime(time);

            if (time != null)
            {
                labelMensagem.Text = "Inserido com Sucesso !";
                labelMensagem.ForeColor = Color.Green;
                LimparTela();
            }
            else
            {
                labelMensagem.Text = "Não foi possível inserir!";
                labelMensagem.ForeColor = Color.Red;
            }

        }

        private void LimparTela()
        {
            textBoxNome.Clear();
            textBoxHistoria.Clear();
            textBoxAnoFundacao.Clear();
            textBoxQtdeTorcedores.Clear();
            textBoxQtdeTitulos.Clear();
        }
    }
}
