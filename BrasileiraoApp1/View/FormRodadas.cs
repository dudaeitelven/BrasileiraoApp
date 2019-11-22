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
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.RODADA' table. You can move, or remove it, as needed.
            this.rODADATableAdapter.Fill(this.dataSetCAMPEONATOS.RODADA);
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.CAMPEONATO' table. You can move, or remove it, as needed.
            this.cAMPEONATOTableAdapter.Fill(this.dataSetCAMPEONATOS.CAMPEONATO);


            //using (CAMPEONATOSEntities c = new CAMPEONATOSEntities())
            //{
            //CAMPEONATOSEntities c = new CAMPEONATOSEntities();
            //    var camp = from CAMPEONATO in c.CAMPEONATO select CAMPEONATO;
            //    cbCampeonato.DataSource = camp.ToList();
            //    cbCampeonato.ValueMember = "id";
            //    cbCampeonato.DisplayMember = "descricao";
            //}

        }

        private void cbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }
    }
}
