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
    public partial class FormTabelaClassificacao : Form
    {
        public FormTabelaClassificacao()
        {
            InitializeComponent();
        }

        private void FormTabelaClassificacao_Load(object sender, EventArgs e)
        {
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
            FillGridTabelaClassificacao fillGrid = new FillGridTabelaClassificacao();
            List<FillGridTabelaClassificacao> fillGridList = new List<FillGridTabelaClassificacao>();

            //Buscar classificação do campeonato e rodada selecionado.
            fillGridList = fillGrid.RetornarClassificacaoRodada(Convert.ToInt32(cbCampeonato.SelectedValue), Convert.ToInt32(cbRodada.SelectedItem));

            //Cria a grid em tempo de execução
            dataGridViewTabelaClassifi.DataSource = fillGridList;

            //Redefinir as colunas da grid em tempo de execução.
            dataGridViewTabelaClassifi.Columns[0].HeaderText = "Numero rodada";
            dataGridViewTabelaClassifi.Columns[1].HeaderText = "Time";
            dataGridViewTabelaClassifi.Columns[2].HeaderText = "Pontos";
            dataGridViewTabelaClassifi.Columns[3].HeaderText = "Saldo gols";
            dataGridViewTabelaClassifi.Columns[4].HeaderText = "Total faltas";
        }
    }
}
