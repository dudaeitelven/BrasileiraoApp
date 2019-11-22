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
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.RODADA' table. You can move, or remove it, as needed.
            this.rODADATableAdapter.Fill(this.dataSetCAMPEONATOS.RODADA);
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.CAMPEONATO' table. You can move, or remove it, as needed.
            this.cAMPEONATOTableAdapter.Fill(this.dataSetCAMPEONATOS.CAMPEONATO);
            // TODO: This line of code loads data into the 'dataSetCAMPEONATOS.RESULTADO' table. You can move, or remove it, as needed.
            this.rESULTADOTableAdapter.Fill(this.dataSetCAMPEONATOS.RESULTADO);

        }
    }
}
