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

        private void btnResultadoRodadas_Click_1(object sender, EventArgs e)
        {
            FormCadastrarResultados cadastrarResultados = new FormCadastrarResultados();
            cadastrarResultados.Show();
        }

        private void btnTimesCampeonatos_Click(object sender, EventArgs e)
        {

        }
    }
}
