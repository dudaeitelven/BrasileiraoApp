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
    public partial class FormCadastrarResultados : Form
    {
        public FormCadastrarResultados()
        {
            InitializeComponent();
        }

        private void FormCadastrarResultados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.JOGO' table. You can move, or remove it, as needed.
            this.jOGOTableAdapter.Fill(this.dataSetCAMPEONATOS.JOGO);
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.CAMPEONATO' table. You can move, or remove it, as needed.
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
            FillGridCadastrarResultados fillGrid = new FillGridCadastrarResultados();
            List<FillGridCadastrarResultados> fillGridList = new List<FillGridCadastrarResultados>();

            //Buscar todos os jogos da campeonato e rodada selecionado.
            fillGridList = fillGrid.RetornarJogos(Convert.ToInt32(cbCampeonato.SelectedValue), Convert.ToInt32(cbRodada.SelectedItem));

            //Cria a grid em tempo de execução
            dataGridViewResultados.DataSource = fillGridList;

            //Redefinir as colunas da grid em tempo de execução.
            dataGridViewResultados.Columns[0].Visible = false;
            dataGridViewResultados.Columns[1].Visible = false;
            dataGridViewResultados.Columns[5].Visible = false;

            dataGridViewResultados.Columns[2].HeaderText = "Time casa";
            dataGridViewResultados.Columns[3].HeaderText = "Gols time casa";
            dataGridViewResultados.Columns[4].HeaderText = "Faltas time casa";

            dataGridViewResultados.Columns[6].HeaderText = "Time Visitante";
            dataGridViewResultados.Columns[7].HeaderText = "Gols time visitante";
            dataGridViewResultados.Columns[8].HeaderText = "Faltas time visitante";
        }
    }
}
