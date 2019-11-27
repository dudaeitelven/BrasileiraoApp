using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillGridTabelaClassificacao
    {
        private int resNumeroRodada;
        private string resTime;
        private int resPontos;
        private int resSaldoGols;
        private int resTotalFaltas;

        public int ResNumeroRodada { get => resNumeroRodada; set => resNumeroRodada = value; }
        public string ResTime { get => resTime; set => resTime = value; }
        public int ResPontos { get => resPontos; set => resPontos = value; }
        public int ResSaldoGols { get => resSaldoGols; set => resSaldoGols = value; }
        public int ResTotalFaltas { get => resTotalFaltas; set => resTotalFaltas = value; }

        public List<FillGridTabelaClassificacao> RetornarClassificacaoRodada(int idCampeonato, int nroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from resultado in context.RESULTADO
                            join rodada in context.RODADA on resultado.idRodada equals rodada.id
                            join time in context.TIME on resultado.idTime equals time.id
                            where resultado.idCampeonato == idCampeonato && rodada.numeroRodada == nroRodada
                            orderby resultado.pontos descending, resultado.saldoGols descending
                            select new FillGridTabelaClassificacao
                            {
                                resNumeroRodada = rodada.numeroRodada,
                                resTime = time.nome,
                                resPontos = resultado.pontos,
                                resSaldoGols = resultado.saldoGols
                                //resTotalFaltas
                            };

                return query.ToList();

            }
        }
    }
}
