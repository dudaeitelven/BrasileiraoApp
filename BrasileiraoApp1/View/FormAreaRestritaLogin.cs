using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrasileiraoApp.Model;

namespace BrasileiraoApp.View
{
    public partial class FormAreaRestritaLogin : Form
    {
        public FormAreaRestritaLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ValidarLogin valida = new ValidarLogin();
            bool liberado=false;
            
            USUARIO user = new USUARIO();
            user.usuario1 = txtUsuario.Text;
            user.senha = txtSenha.Text;

            AtualizarMsgLogin();
            liberado = valida.LiberarLogin(user);

            if (liberado)
            {
                FormAreaRestrita areaRestrita = new FormAreaRestrita();
                areaRestrita.Show();
                AcertarAutenticacao();
            }
            else
            {
                FalharAutenticacao();
            }
        }

        private void AtualizarMsgLogin()
        {
            labelMsg.Text = "Validando login, aguarde!";
            labelMsg.ForeColor = Color.Green;
        }
        private void AcertarAutenticacao()
        {
            this.Hide();
        }
        private void FalharAutenticacao()
        {
            labelMsg.Text = "Login ou senha inválidos!";
            labelMsg.ForeColor = Color.Red;
        }
    }
}
