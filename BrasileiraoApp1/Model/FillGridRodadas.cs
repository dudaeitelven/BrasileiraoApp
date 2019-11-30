using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillGridRodadas
    {
        private int resNumeroRodada;
        private string resDataRodada;
        private string resTimeCasa;
        private string resTimeVisitante;

        public int ResNumeroRodada { get => resNumeroRodada; set => resNumeroRodada = value; }
        public string ResDataRodada { get => resDataRodada; set => resDataRodada = value; }
        public string ResTimeCasa { get => resTimeCasa; set => resTimeCasa = value; }
        public string ResTimeVisitante { get => resTimeVisitante; set => resTimeVisitante = value; }

        public List<FillGridRodadas> RetornarTimesRodadas(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from jogo in context.JOGO
                            join rodada in context.RODADA on jogo.idRodada equals rodada.id
                            join timeCasa in context.TIME on jogo.idTimeCasa equals timeCasa.id
                            join timeVisitante in context.TIME on jogo.idTimeVisitante equals timeVisitante.id
                            where jogo.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            orderby rodada.numeroRodada
                            select new FillGridRodadas
                            {
                                resNumeroRodada = rodada.numeroRodada,
                                resDataRodada = rodada.dataRodada.ToString(),
                                resTimeCasa = timeCasa.nome,
                                resTimeVisitante = timeVisitante.nome
                            };

                return query.ToList();
            }
        }
    }
}
