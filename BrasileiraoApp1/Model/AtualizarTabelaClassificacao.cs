using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class AtualizarTabelaClassificacao
    {
        int resIdRodada;
        int resNroRodada;
        int resIdTimeCasa;
        int resGolsCasa;
        int resGolsVisitante;
        int resNumeroFaltasCasa;
        int resPontos;
        float resSaldoGols;

        public int ResIdRodada { get => resIdRodada; set => resIdRodada = value; }
        public int ResNroRodada { get => resNroRodada; set => resNroRodada = value; }
        public int ResIdTimeCasa { get => resIdTimeCasa; set => resIdTimeCasa = value; }
        public int ResGolsCasa { get => resGolsCasa; set => resGolsCasa = value; }
        public int ResGolsVisitante { get => resGolsVisitante; set => resGolsVisitante = value; }
        public int ResNumeroFaltasCasa { get => resNumeroFaltasCasa; set => resNumeroFaltasCasa = value; }
        public int ResPontos { get => resPontos; set => resPontos = value; }
        public float ResSaldoGols { get => resSaldoGols; set => resSaldoGols = value; }

        public List<AtualizarTabelaClassificacao> retornarDadosTimesCasa(int idCampeonato, int idTime)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query =
                    (from jogo in context.JOGO
                     join rodada in context.RODADA on jogo.idRodada equals rodada.id
                     //join time in context.TIME on jogo.idTimeCasa equals time.id
                     where jogo.idCampeonato == idCampeonato && jogo.idTimeCasa == idTime
                     select new AtualizarTabelaClassificacao
                     {
                         resIdRodada = jogo.idRodada,
                         resNroRodada = rodada.numeroRodada,
                         resIdTimeCasa = jogo.idTimeCasa,
                         resGolsCasa = jogo.golsCasa,
                         resGolsVisitante = jogo.golsVisitante,
                         resNumeroFaltasCasa = jogo.numeroFaltasCasa,
                         resPontos = jogo.numeroFaltasCasa != 0 && jogo.numeroFaltasVisitante != 0 ? (jogo.golsCasa > jogo.golsVisitante ? 3 : (jogo.golsCasa == jogo.golsVisitante ? 1 : 0)) : 0,
                         resSaldoGols = jogo.golsCasa - jogo.golsVisitante
                     });
                return query.ToList();
            }
        }

        public List<AtualizarTabelaClassificacao> retornarDadosTimesVisitante(int idCampeonato, int idTime)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query =
                    (from jogo in context.JOGO
                     join rodada in context.RODADA on jogo.idRodada equals rodada.id
                     //join time in context.TIME on jogo.idTimeVisitante equals time.id
                     where jogo.idCampeonato == idCampeonato && jogo.idTimeVisitante == idTime
                     select new AtualizarTabelaClassificacao
                     {
                         resIdRodada = jogo.idRodada,
                         resNroRodada = rodada.numeroRodada,
                         resIdTimeCasa = jogo.idTimeVisitante,
                         resGolsCasa = jogo.golsVisitante,
                         resGolsVisitante = jogo.golsCasa,
                         resNumeroFaltasCasa = jogo.numeroFaltasVisitante,
                         resPontos = jogo.numeroFaltasCasa != 0 && jogo.numeroFaltasVisitante != 0 ? (jogo.golsVisitante > jogo.golsCasa ? 3 : (jogo.golsCasa == jogo.golsVisitante ? 1 : 0)) : 0,
                         resSaldoGols = jogo.golsVisitante - jogo.golsCasa
                     });
                return query.ToList();
            }
        }

        public List<AtualizarTabelaClassificacao> retornarTimesCampeonato(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query =
                    (from timeCameponato in context.TIME_CAMPEONATO
                     where timeCameponato.idCampeonato == idCampeonato
                     select new AtualizarTabelaClassificacao
                     {
                         resIdTimeCasa = timeCameponato.idTime
                     });
                return query.ToList();
            }
        }


        public void limparDadosTabelaClassificacao(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                int noOfRowDeleted = context.Database.ExecuteSqlCommand("Delete from RESULTADO where idCampeonato = " + idCampeonato);
            }

            
        }

        public void calcularResultados(int idCampeonato)
        {
            int i = 0;
            int j = 0;
            int auxIdRodada;
            int auxNroRodada;
            int auxIdTime;
            int auxNumeroFaltas = 0;
            int auxPontos = 0;
            float auxSaldoGols = 0;

            AtualizarTabelaClassificacao atualizarTabelaClassificacao = new AtualizarTabelaClassificacao();
            List<AtualizarTabelaClassificacao> listTimeCampeonato = new List<AtualizarTabelaClassificacao>();
            List<AtualizarTabelaClassificacao> listTimeCasa = new List<AtualizarTabelaClassificacao>();
            List<AtualizarTabelaClassificacao> listTimeVistante = new List<AtualizarTabelaClassificacao>();
            List<AtualizarTabelaClassificacao> listTimeRodadas = new List<AtualizarTabelaClassificacao>();

            //Limpa a tabela resultado
            atualizarTabelaClassificacao.limparDadosTabelaClassificacao(idCampeonato);

            //Retornar os times do campeonato
            listTimeCampeonato = atualizarTabelaClassificacao.retornarTimesCampeonato(idCampeonato);
            listTimeCampeonato = listTimeCampeonato.OrderBy(Ord => Ord.resIdTimeCasa).ToList();

            for (i = 0; i < listTimeCampeonato.Count; i++)
            {
                //Retorna os jogos em casa
                listTimeCasa = atualizarTabelaClassificacao.retornarDadosTimesCasa(idCampeonato,listTimeCampeonato[i].resIdTimeCasa);
                listTimeCasa = listTimeCasa.OrderBy(Ord => Ord.resIdRodada).ToList();

                //Retorna os jogos fora
                listTimeVistante = atualizarTabelaClassificacao.retornarDadosTimesVisitante(idCampeonato, listTimeCampeonato[i].resIdTimeCasa);
                listTimeVistante = listTimeVistante.OrderBy(Ord => Ord.resIdRodada).ToList();

                //Concatena todos os jogos do time em uma só lista
                listTimeRodadas = listTimeCasa.Concat(listTimeVistante).ToList();
                
                //Percorre a lista de jogos do time
                for (j = 0; j < listTimeRodadas.Count; j++)
                {
                    auxIdRodada = listTimeRodadas[j].resIdRodada;
                    auxNroRodada = listTimeRodadas[j].resNroRodada;
                    auxIdTime = listTimeRodadas[j].resIdTimeCasa;

                    //Acumula os valores por rodada
                    auxNumeroFaltas += listTimeRodadas[j].resNumeroFaltasCasa;
                    auxPontos += listTimeRodadas[j].resPontos;
                    auxSaldoGols += listTimeRodadas[j].resSaldoGols;

                    //Persiste os dados na tabela RESULTADO
                    salvarResultado(auxIdTime, auxIdRodada, idCampeonato, auxPontos, auxNumeroFaltas, auxSaldoGols);
                }

                //Zera auxiliares
                auxNumeroFaltas = 0;
                auxPontos = 0;
                auxSaldoGols = 0;
            }      

        }

        public void salvarResultado(int auxIdTime, int auxIdRodada, int idCampeonato, int auxPontos, int auxNumeroFaltas, double auxSaldoGols)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                RESULTADO resultado = new RESULTADO(auxIdTime, auxIdRodada, idCampeonato, auxPontos, auxNumeroFaltas, auxSaldoGols);
                context.RESULTADO.Add(resultado);
                context.SaveChanges();
            }
        }
    }
}
