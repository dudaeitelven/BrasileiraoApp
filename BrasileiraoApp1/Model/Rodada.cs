using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    class Rodada
    {
        private int id;
        private int idCampeonato;
        private int numeroRodada;
        private DateTime dataRodada;

        public Rodada(int id, int idCampeonato, int numeroRodada, DateTime dataRodada)
        {
            this.id = id;
            this.idCampeonato = idCampeonato;
            this.numeroRodada = numeroRodada;
            this.dataRodada = dataRodada;
        }

        public int Id { get => id; set => id = value; }
        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public int NumeroRodada { get => numeroRodada; set => numeroRodada = value; }
        public DateTime DataRodada { get => dataRodada; set => dataRodada = value; }
    }
}
