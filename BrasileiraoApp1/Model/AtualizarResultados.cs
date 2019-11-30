using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class AtualizarResultados
    {
        private int resIdResultado;
        private int resGolsTimeCasa;
        private int resFaltasTimeCasa;
        private int resGolsTimeVisitante;
        private int resFaltasTimeVisitante;

        public AtualizarResultados(int resIdResultado, int resGolsTimeCasa, int resFaltasTimeCasa, int resGolsTimeVisitante, int resFaltasTimeVisitante)
        {
            this.resIdResultado = resIdResultado;
            this.resGolsTimeCasa = resGolsTimeCasa;
            this.resFaltasTimeCasa = resFaltasTimeCasa;
            this.resGolsTimeVisitante = resGolsTimeVisitante;
            this.resFaltasTimeVisitante = resFaltasTimeVisitante;
        }

        public int ResIdResultado { get => resIdResultado; set => resIdResultado = value; }
        public int ResGolsTimeCasa { get => resGolsTimeCasa; set => resGolsTimeCasa = value; }
        public int ResFaltasTimeCasa { get => resFaltasTimeCasa; set => resFaltasTimeCasa = value; }
        public int ResGolsTimeVisitante { get => resGolsTimeVisitante; set => resGolsTimeVisitante = value; }
        public int ResFaltasTimeVisitante { get => resFaltasTimeVisitante; set => resFaltasTimeVisitante = value; }

        public void salvarResultados(AtualizarResultados resultados)
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
