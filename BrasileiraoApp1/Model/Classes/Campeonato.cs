using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model.Classes
{
    class Campeonato
    {
        private int id;
        private string descricao;
        private string historia;
        private int ano;
        private int quantidadeTimes;

        public Campeonato(int id, string descricao, string historia, int ano, int quantidadeTimes)
        {
            this.id = id;
            this.descricao = descricao;
            this.historia = historia;
            this.ano = ano;
            this.quantidadeTimes = quantidadeTimes;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Historia { get => historia; set => historia = value; }
        public int Ano { get => ano; set => ano = value; }
        public int QuantidadeTimes { get => quantidadeTimes; set => quantidadeTimes = value; }
    }
}
