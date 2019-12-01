using BrasileiraoApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiraoApp.View
{
    public partial class FormRodadas : Form
    {
        public FormRodadas()
        {
            InitializeComponent();
        }

        private void FormRodadas_Load(object sender, EventArgs e)
        {
            this.cAMPEONATOTableAdapter.Fill(this.dataSetCAMPEONATOS.CAMPEONATO);
            cbCampeonato.SelectedIndex = -1;
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

        }

        private void cbRodada_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGridRodadas fillGrid = new FillGridRodadas();
            List<FillGridRodadas> fillGridList = new List<FillGridRodadas>();

            //Buscar todos os jogos da campeonato e rodada selecionado.
            fillGridList = fillGrid.RetornarTimesRodadas(Convert.ToInt32(cbCampeonato.SelectedValue), Convert.ToInt32(cbRodada.SelectedItem));

            //Cria a grid em tempo de execução
            dataGridViewRodada.DataSource = fillGridList;

            //Redefinir as colunas da grid em tempo de execução.
            dataGridViewRodada.Columns[0].HeaderText = "Numero rodada";
            dataGridViewRodada.Columns[1].HeaderText = "Data rodada";
            dataGridViewRodada.Columns[2].HeaderText = "Time casa";
            dataGridViewRodada.Columns[3].HeaderText = "Time visitante";

            dataGridViewRodada.Columns[1].DefaultCellStyle.Format = "d";
        }

        private void dataGridViewRodada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
