using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class AtualizarTabelaClassificacao
    {
 
        public void retornarDadosTimeCasa(int idCampeonato,int nroRodada, int idTime)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var calculosCasa =
                    (from jogo in context.JOGO
                     join rodada in context.RODADA on jogo.idRodada equals rodada.id
                     where jogo.idCampeonato == idCampeonato && rodada.numeroRodada <= nroRodada
                     && jogo.idTimeCasa == idTime
                     group jogo by jogo.idTimeCasa into jogoGroup
                     select new
                     {
                         Time = jogoGroup.Key,
                         SaldoGols = (jogoGroup.Sum(x => x.golsCasa) - jogoGroup.Sum(x => x.golsVisitante)),
                         Faltas = jogoGroup.Sum(x => x.numeroFaltasCasa),
                     }).First();

                var calculosFora =
                    (from jogo in context.JOGO
                     join rodada in context.RODADA on jogo.idRodada equals rodada.id
                     where jogo.idCampeonato == idCampeonato && rodada.numeroRodada <= nroRodada
                     && jogo.idTimeVisitante == idTime
                     group jogo by jogo.idTimeVisitante into jogoGroup
                     select new
                     {
                         Time = jogoGroup.Key,
                         SaldoGols = (jogoGroup.Sum(x => x.golsCasa) - jogoGroup.Sum(x => x.golsVisitante)),
                         Faltas = jogoGroup.Sum(x => x.numeroFaltasCasa),
                     }).First();

                var scoreFora  =
                    (from jogo in context.JOGO
                     join rodada in context.RODADA on jogo.idRodada equals rodada.id
                     where jogo.idCampeonato == idCampeonato && rodada.numeroRodada <= nroRodada && jogo.idTimeVisitante == idTime
                     group jogo by jogo.idTimeVisitante into jogoGroup
                     select new
                     {
                         Time = jogoGroup.Key,
                         Pontos = (
                                     jogoGroup.Sum(x => x.golsCasa > x.golsVisitante ? 3 :
                                                        x.golsCasa == x.golsVisitante ? 1 : 0))
                     }).First();

                //from u in users
                //let range = (u.Age >= 0 && u.Age < 10 ? "0-25" :
                //             u.Age >= 10 && u.Age < 15 ? "26-40" :
                //             u.Age >= 15 && u.Age < 50 ? "60-100" :
                //            "50+")
                //group u by range into g
                //select new { g.Key, Count = g.Count() };

                var scoreCasa =
                    (from jogo in context.JOGO
                     join rodada in context.RODADA on jogo.idRodada equals rodada.id
                     where jogo.idCampeonato == idCampeonato && rodada.numeroRodada <= nroRodada && jogo.idTimeCasa == idTime
                     group jogo by jogo.idTimeCasa into jogoGroup
                     select new
                     {
                         Time = jogoGroup.Key,
                         Pontos = (
                                     jogoGroup.Sum(x => x.golsCasa > x.golsVisitante ? 3 :
                                                        x.golsCasa == x.golsVisitante ? 1 : 0))
                    }).First();

                var TotalSaldoGols = 0;
                var TotalFaltas = 0;
                var TotalPontos = 0;

                if (calculosCasa.Time == calculosFora.Time)
                {
                    TotalSaldoGols = calculosCasa.SaldoGols + calculosFora.SaldoGols;
                    TotalFaltas = calculosCasa.Faltas + calculosFora.Faltas;
                }

                if (scoreCasa.Time == scoreFora.Time)
                {
                    TotalPontos = scoreCasa.Pontos + scoreCasa.Pontos;
                }

                var queryRoda = (from rodada in context.RODADA
                                 where rodada.numeroRodada == nroRodada && rodada.idCampeonato == idCampeonato
                                 select rodada.id
                                 ).First();

                RESULTADO resultado = new RESULTADO(idTime, queryRoda, idCampeonato,TotalPontos,TotalSaldoGols,TotalFaltas);
                context.RESULTADO.Add(resultado);
                context.SaveChanges();
            }
        }

    }
}
