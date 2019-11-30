using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillGridTabelaEstatistica
    {
        private string resTime;
        private int resSaldoGols;
        private int resTotalFaltas;

        public string ResTime { get => resTime; set => resTime = value; }
        public int ResSaldoGols { get => resSaldoGols; set => resSaldoGols = value; }
        public int ResTotalFaltas { get => resTotalFaltas; set => resTotalFaltas = value; }

        public List<FillGridTabelaEstatistica> RetornarEstatisticaMaisGols(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from resultado in context.RESULTADO
                            join rodada in context.RODADA on resultado.idRodada equals rodada.id
                            join time in context.TIME on resultado.idTime equals time.id
                            where resultado.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            orderby resultado.saldoGols descending
                            select new FillGridTabelaEstatistica
                            {
                                resTime = time.nome,
                                resSaldoGols = resultado.saldoGols,
                                resTotalFaltas = resultado.totalFaltas
                            };

                return query.ToList();

            }
        }

        public List<FillGridTabelaEstatistica> RetornarEstatisticaMenosGols(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from resultado in context.RESULTADO
                            join rodada in context.RODADA on resultado.idRodada equals rodada.id
                            join time in context.TIME on resultado.idTime equals time.id
                            where resultado.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            orderby resultado.saldoGols
                            select new FillGridTabelaEstatistica
                            {
                                resTime = time.nome,
                                resSaldoGols = resultado.saldoGols,
                                resTotalFaltas = resultado.totalFaltas
                            };

                return query.ToList();

            }
        }

        public List<FillGridTabelaEstatistica> RetornarEstatisticaMaisFaltas(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from resultado in context.RESULTADO
                            join rodada in context.RODADA on resultado.idRodada equals rodada.id
                            join time in context.TIME on resultado.idTime equals time.id
                            where resultado.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            orderby resultado.totalFaltas descending
                            select new FillGridTabelaEstatistica
                            {
                                resTime = time.nome,
                                resSaldoGols = resultado.saldoGols,
                                resTotalFaltas = resultado.totalFaltas
                            };

                return query.ToList();

            }
        }

        public List<FillGridTabelaEstatistica> RetornarEstatisticaMenosFaltas(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from resultado in context.RESULTADO
                            join rodada in context.RODADA on resultado.idRodada equals rodada.id
                            join time in context.TIME on resultado.idTime equals time.id
                            where resultado.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            orderby resultado.totalFaltas
                            select new FillGridTabelaEstatistica
                            {
                                resTime = time.nome,
                                resSaldoGols = resultado.saldoGols,
                                resTotalFaltas = resultado.totalFaltas
                            };

                return query.ToList();

            }
        }
    }
}
