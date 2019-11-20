using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    class Usuario
    {
        private int id;
        private string usuario;
        private string senha;
        private string email;
        private DateTime dataNascimento;

        public Usuario(int id, string usuario, string senha, string email, DateTime dataNascimento)
        {
            this.id = id;
            this.usuario = usuario;
            this.senha = senha;
            this.email = email;
            this.dataNascimento = dataNascimento;
        }

        public int Id { get => id; set => id = value; }

        public string GetUsuario()
        {
            return usuario;
        }

        public void SetUsuario(string value)
        {
            usuario = value;
        }

        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
