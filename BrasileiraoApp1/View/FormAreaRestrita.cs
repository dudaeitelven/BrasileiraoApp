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
    public partial class FormAreaRestrita : Form
    {
        public FormAreaRestrita()
        {
            InitializeComponent();
        }

        private void btnTimesCampeonatos_Click(object sender, EventArgs e)
        {
            FormCadastrarTime cadastrarTime = new FormCadastrarTime();
            cadastrarTime.Show();
        }

        private void btnCadastrarCampeonato_Click(object sender, EventArgs e)
        {
            FormCadastrarCampeonato cadastrarCampeonato = new FormCadastrarCampeonato();
            cadastrarCampeonato.Show();
        }

        private void buttonVincularTimes_Click(object sender, EventArgs e)
        {
            FormVincularTimes vincularTimes = new FormVincularTimes();
            vincularTimes.Show();
        }

        private void buttonGerarRodadas_Click(object sender, EventArgs e)
        {
            FormGerarRodadas gerarRodadas = new FormGerarRodadas();
            gerarRodadas.Show();
        }

        private void btnResultadoRodadas_Click_1(object sender, EventArgs e)
        {
            FormCadastrarResultados cadastrarResultados = new FormCadastrarResultados();
            cadastrarResultados.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
