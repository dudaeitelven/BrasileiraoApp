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
    public partial class FormVincularTimes : Form
    {
        public FormVincularTimes()
        {
            InitializeComponent();
        }

        private void FormVincularTimes_Load(object sender, EventArgs e)
        {
            this.cAMPEONATOTableAdapter.Fill(this.dataSetCAMPEONATOS.CAMPEONATO);
            cbCampeonato.SelectedIndex = -1;

            dataGridViewVinculados.DataSource = null;
            dataGridViewNaoVinculados.DataSource = null;
        }

        private void cbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            montarGrids();
        }

        private void buttonVincular_Click(object sender, EventArgs e)
        {
            VincularTimes vincularTimes = new VincularTimes();

            int idTime = Convert.ToInt32(dataGridViewNaoVinculados.CurrentRow.Cells[1].Value.ToString());
            int idCampeonato = Convert.ToInt32(cbCampeonato.SelectedValue);

            TIME_CAMPEONATO timeCampeonato = new TIME_CAMPEONATO(idTime, idCampeonato);
            vincularTimes.vincularTimeCampeonato(timeCampeonato);

            montarGrids();
        }

        private void buttonDesvincular_Click(object sender, EventArgs e)
        {
            VincularTimes desvincularTimes = new VincularTimes();

            int idTime = Convert.ToInt32(dataGridViewVinculados.CurrentRow.Cells[1].Value.ToString());
            int idCampeonato = Convert.ToInt32(cbCampeonato.SelectedValue);

            TIME_CAMPEONATO timeCampeonato = new TIME_CAMPEONATO(idTime, idCampeonato);
            desvincularTimes.desvincularTimeCampeonato(timeCampeonato);

            montarGrids();
        }

        public void montarGrids()
        {
            VincularTimes vincularTimes = new VincularTimes();
            List<VincularTimes> timesVinculados = new List<VincularTimes>();
            List<VincularTimes> timesNaoVinculados = new List<VincularTimes>();

            //Buscar times vinculados ao campeonato
            timesVinculados = vincularTimes.CarregarVinculados(Convert.ToInt32(cbCampeonato.SelectedValue));
            dataGridViewVinculados.DataSource = timesVinculados;

            //Buscar times não vinculados ao campeonato
            timesNaoVinculados = vincularTimes.CarregarNaoVinculados(Convert.ToInt32(cbCampeonato.SelectedValue));
            dataGridViewNaoVinculados.DataSource = timesNaoVinculados;

            //Redefinir as colunas da grid em tempo de execução.
            dataGridViewVinculados.Columns[1].Visible = false;
            dataGridViewVinculados.Columns[0].HeaderText = "Time";
            dataGridViewVinculados.Columns[0].ReadOnly = true;
            dataGridViewVinculados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewNaoVinculados.Columns[1].Visible = false;
            dataGridViewNaoVinculados.Columns[0].HeaderText = "Time";
            dataGridViewNaoVinculados.Columns[0].ReadOnly = true;
            dataGridViewNaoVinculados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
