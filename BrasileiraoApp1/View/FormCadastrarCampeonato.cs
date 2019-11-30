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
    public partial class FormCadastrarCampeonato : Form
    {
        public FormCadastrarCampeonato()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            CadastrarCampeonato cadastrarCampeonato = new CadastrarCampeonato();
            CAMPEONATO campeonato = new CAMPEONATO(
                                textBoxNome.Text,
                                textBoxHistoria.Text,
                                ((textBoxAno.Text != "") ? (Convert.ToInt32(textBoxAno.Text)) : (0)),
                                ((textBoxQtdeTimes.Text != "") ? (Convert.ToInt32(textBoxQtdeTimes.Text)) : (0))
                                );
            cadastrarCampeonato.SalvarCampeonato(campeonato);

            if (campeonato != null)
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
            textBoxAno.Clear();
            textBoxQtdeTimes.Clear();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
