using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillGridCadastrarResultados
    {
        private int resIdJogo;

        private int resIdTimeCasa;
        private string resTimeCasa;
        private int resGolsTimeCasa;
        private int resFaltasTimeCasa;

        private int resIdTimeVisitante;
        private string resTimeVisitante;
        private int resGolsTimeVisitante;
        private int resFaltasTimeVisitante;

        public int ResIdJogo { get => resIdJogo; set => resIdJogo = value; }
        public int ResIdTimeCasa { get => resIdTimeCasa; set => resIdTimeCasa = value; }
        public string ResTimeCasa { get => resTimeCasa; set => resTimeCasa = value; }
        public int ResGolsTimeCasa { get => resGolsTimeCasa; set => resGolsTimeCasa = value; }
        public int ResFaltasTimeCasa { get => resFaltasTimeCasa; set => resFaltasTimeCasa = value; }
        public int ResIdTimeVisitante { get => resIdTimeVisitante; set => resIdTimeVisitante = value; }
        public string ResTimeVisitante { get => resTimeVisitante; set => resTimeVisitante = value; }
        public int ResGolsTimeVisitante { get => resGolsTimeVisitante; set => resGolsTimeVisitante = value; }
        public int ResFaltasTimeVisitante { get => resFaltasTimeVisitante; set => resFaltasTimeVisitante = value; }

        public List<FillGridCadastrarResultados> RetornarJogos(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from jogo in context.JOGO
                            join rodada in context.RODADA on jogo.idRodada equals rodada.id
                            join timeCasa in context.TIME on jogo.idTimeCasa equals timeCasa.id
                            join timeVisitante in context.TIME on jogo.idTimeVisitante equals timeVisitante.id
                            where jogo.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            select new FillGridCadastrarResultados
                            {
                                resIdJogo = jogo.id,
                                resIdTimeCasa = jogo.idTimeCasa,
                                resTimeCasa = timeCasa.nome,
                                resGolsTimeCasa = jogo.golsCasa,
                                resFaltasTimeCasa = jogo.numeroFaltasCasa,
                                resIdTimeVisitante = jogo.idTimeVisitante,
                                resTimeVisitante = timeVisitante.nome,
                                resGolsTimeVisitante = jogo.golsVisitante,
                                resFaltasTimeVisitante = jogo.numeroFaltasVisitante,
                            };

                return query.ToList();
            }
        }
    }
}
