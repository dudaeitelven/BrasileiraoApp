using BrasileiraoApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiraoApp1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnAreaRestrita_Click(object sender, EventArgs e)
        {
            FormAreaRestrita areaRestrita = new FormAreaRestrita();
            areaRestrita.Show();
        }

        private void btnRodadas_Click(object sender, EventArgs e)
        {
            FormRodadas rodadas = new FormRodadas();
            rodadas.Show();
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            FormEstatistica estatistica = new FormEstatistica();
            estatistica.Show();
        }

        private void btnTabelaClassificacao_Click(object sender, EventArgs e)
        {
            FormTabelaClassificacao tabelaClassificacao = new FormTabelaClassificacao();
            tabelaClassificacao.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
