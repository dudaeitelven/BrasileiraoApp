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
    public partial class FormGerarRodadas : Form
    {
        public FormGerarRodadas()
        {
            InitializeComponent();
        }

        private void FormGerarRodadas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetCAMPEONATOS.CAMPEONATO'. Você pode movê-la ou removê-la conforme necessário.
            this.cAMPEONATOTableAdapter.Fill(this.dataSetCAMPEONATOS.CAMPEONATO);
            cbCampeonato.SelectedIndex = -1;
        }

        private void buttonGerarRodadas_Click(object sender, EventArgs e)
        {
            GerarRodadas gerarRodadas = new GerarRodadas();
            gerarRodadas.realizarSorteio(Convert.ToInt32(cbCampeonato.SelectedValue), dateTimePickerNascimento.Value, checkBoxDuasRodadasSemana.Checked);

        }
    }
}
