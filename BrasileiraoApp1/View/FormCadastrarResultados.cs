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

            dataGridViewResultados.Columns[2].ReadOnly = true;
            dataGridViewResultados.Columns[6].ReadOnly = true;

            dataGridViewResultados.Columns[2].HeaderText = "Time casa";
            dataGridViewResultados.Columns[3].HeaderText = "Gols time casa";
            dataGridViewResultados.Columns[4].HeaderText = "Faltas time casa";

            dataGridViewResultados.Columns[6].HeaderText = "Time Visitante";
            dataGridViewResultados.Columns[7].HeaderText = "Gols time visitante";
            dataGridViewResultados.Columns[8].HeaderText = "Faltas time visitante";
        }

        private void dataGridViewResultados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewResultados.CurrentRow != null)
            {
                int idResultado = int.Parse(dataGridViewResultados.Rows[e.RowIndex].Cells[0].Value.ToString());

                int golsTimeCasa = int.Parse(dataGridViewResultados.Rows[e.RowIndex].Cells[3].Value.ToString());
                int faltasTimeCasa = int.Parse(dataGridViewResultados.Rows[e.RowIndex].Cells[4].Value.ToString());

                int golsTimeVisitante = int.Parse(dataGridViewResultados.Rows[e.RowIndex].Cells[7].Value.ToString());
                int faltasTimeVisitante = int.Parse(dataGridViewResultados.Rows[e.RowIndex].Cells[8].Value.ToString());

                AtualizarResultados atualizarResultados = 
                    new AtualizarResultados(idResultado, golsTimeCasa, faltasTimeCasa, golsTimeVisitante, faltasTimeVisitante);
                atualizarResultados.salvarResultados(atualizarResultados);

                AtualizarTabelaClassificacao atualizarTabelaClassificacao = new AtualizarTabelaClassificacao();

                //Não fazer isso, não esta pronto!
                for (int i = 1; i <= Convert.ToInt32(cbRodada.SelectedItem); i++)
                {
                    atualizarTabelaClassificacao.retornarDadosTimeCasa(Convert.ToInt32(cbCampeonato.SelectedValue), i, Convert.ToInt32(dataGridViewResultados.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    atualizarTabelaClassificacao.retornarDadosTimeCasa(Convert.ToInt32(cbCampeonato.SelectedValue), i, Convert.ToInt32(dataGridViewResultados.Rows[e.RowIndex].Cells[5].Value.ToString()));
                }
                //Não fazer isso, não esta pronto!

            }

        }
    }
}
