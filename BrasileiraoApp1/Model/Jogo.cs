using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    class Jogo
    {
        private int id;
        private int idRodada;
        private int idCampeonato;
        private int idTimeCasa;
        private int golsCasa;
        private int numeroFaltasCasa;
        private int idTimeVisitante;
        private int golsVisitante;
        private int numeroFaltasVisitante;
        private string observacaoJogo;

        public Jogo(int id, int idRodada, int idCampeonato, int idTimeCasa, int golsCasa, int numeroFaltasCasa, int idTimeVisitante, int golsVisitante, int numeroFaltasVisitante, string observacaoJogo)
        {
            this.id = id;
            this.idRodada = idRodada;
            this.idCampeonato = idCampeonato;
            this.idTimeCasa = idTimeCasa;
            this.golsCasa = golsCasa;
            this.numeroFaltasCasa = numeroFaltasCasa;
            this.idTimeVisitante = idTimeVisitante;
            this.golsVisitante = golsVisitante;
            this.numeroFaltasVisitante = numeroFaltasVisitante;
            this.observacaoJogo = observacaoJogo;
        }

        public int Id { get => id; set => id = value; }
        public int IdRodada { get => idRodada; set => idRodada = value; }
        public int IdCampeonato { get => idCampeonato; set => idCampeonato = value; }
        public int IdTimeCasa { get => idTimeCasa; set => idTimeCasa = value; }
        public int GolsCasa { get => golsCasa; set => golsCasa = value; }
        public int NumeroFaltasCasa { get => numeroFaltasCasa; set => numeroFaltasCasa = value; }
        public int IdTimeVisitante { get => idTimeVisitante; set => idTimeVisitante = value; }
        public int GolsVisitante { get => golsVisitante; set => golsVisitante = value; }
        public int NumeroFaltasVisitante { get => numeroFaltasVisitante; set => numeroFaltasVisitante = value; }
        public string ObservacaoJogo { get => observacaoJogo; set => observacaoJogo = value; }
    }
}
