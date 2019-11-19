using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model.Classes
{
    class Time
    {
        private int id;
        private string nome;
        private string historia;
        private DateTime anoFundacao;
        private float quantidadeTorcedores;
        private int quantidadeTitulos;

        public Time(int id, string nome, string historia, DateTime anoFundacao, float quantidadeTorcedores, int quantidadeTitulos)
        {
            this.id = id;
            this.nome = nome;
            this.historia = historia;
            this.anoFundacao = anoFundacao;
            this.quantidadeTorcedores = quantidadeTorcedores;
            this.quantidadeTitulos = quantidadeTitulos;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Historia { get => historia; set => historia = value; }
        public DateTime AnoFundacao { get => anoFundacao; set => anoFundacao = value; }
        public float QuantidadeTorcedores { get => quantidadeTorcedores; set => quantidadeTorcedores = value; }
        public int quantidadeTitulos { get => quantidadeTitulos; set => quantidadeTitulos = value; }
    }
}
