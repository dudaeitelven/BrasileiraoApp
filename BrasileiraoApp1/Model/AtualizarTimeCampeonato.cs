using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class AtualizarTimeCampeonato
    {
        private int resIdResultado;
        private int resGolsTimeCasa;
        private int resFaltasTimeCasa;
        private int resGolsTimeVisitante;
        private int resFaltasTimeVisitante;

        public void salvarResultados(AtualizarTimeCampeonato resultados)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {                
                var queryToUpdate = from jogo in context.JOGO
                                    where jogo.id == resultados.resIdResultado
                                    select jogo;
                foreach (var jogoToUpdate in queryToUpdate)
                {
                    jogoToUpdate.golsCasa = resultados.resGolsTimeCasa;
                    jogoToUpdate.numeroFaltasCasa = resultados.resFaltasTimeCasa;
                    jogoToUpdate.golsVisitante = resultados.resGolsTimeVisitante;
                    jogoToUpdate.numeroFaltasVisitante = resultados.resFaltasTimeVisitante;
                }
                context.SaveChanges();
            }
        }

    }
}
