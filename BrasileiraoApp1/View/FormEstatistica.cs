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
    public partial class FormEstatistica : Form
    {
        public FormEstatistica()
        {
            InitializeComponent();
        }

        private void FormEstatistica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.CAMPEONATO' table. You can move, or remove it, as needed.
            this.cAMPEONATOTableAdapter.Fill(this.dataSetCAMPEONATOS.CAMPEONATO);
            cbCampeonato.SelectedIndex = -1;
            cbEstatistica.SelectedIndex = -1;
        }

        private void cbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboRodadas fillRodadas = new FillComboRodadas();
            List<int> fillRodadasList = new List<int>();

            //Limpa a seleção do combobox rodada
            cbRodada.SelectedIndex = -1;
            cbRodada.Items.Clear();

            //Pegar o id selecionado no combo campeonato.
            Object selectedValue = cbCampeonato.SelectedValue;

            //Popular a List para montar o combo rodadas.
            fillRodadasList = fillRodadas.RetornarRodadas(Convert.ToInt32(selectedValue));

            //Montar o combo rodadas.
            foreach (var lineListRodadas in fillRodadasList)
            {
                cbRodada.Items.Add(lineListRodadas.ToString());
            }

            //Populando o combo estatisticas
            FillComboEstatistica fillComboEstatistica = new FillComboEstatistica();
            List<string> fillEstatisticasList = new List<string>();

            fillEstatisticasList = fillComboEstatistica.RetornarEstatisticas();
            cbEstatistica.DataSource = fillEstatisticasList;
        }

        private void cbEstatistica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
