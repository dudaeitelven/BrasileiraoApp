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
        }

        private void cbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            VincularTimes vincularTimes = new VincularTimes();

            //Pegar o id selecionado no combo campeonato.
            //Object selectedValue = cbCampeonato.SelectedValue;
            //vincularTimes.CarregarVinculados()
        }
    }
}
