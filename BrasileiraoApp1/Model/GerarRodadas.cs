using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiraoApp.Model
{
    public class GerarRodadas
    {
        private const int BYE = -1;

        // Return an array where results(i, j) gives
        // the opponent of team i in round j.
        // Note: num_teams must be odd.
        private int[,] GenerateRoundRobinOdd(int num_teams) //assume time sendo 19
        {
            int n2 = (int)((num_teams - 1) / 2); //n2 = 9
            int[,] results = new int[num_teams, num_teams]; //matriz 19 19
            // Initialize the list of teams.
            int[] teams = new int[num_teams]; //VETOR de 19 posicoes
            for (int i = 0; i < num_teams; i++) teams[i] = i; //coloca a numeracao dos times
            // Start the rounds.
            for (int round = 0; round < num_teams; round++) //round vai de 0 a 18
            {
                for (int i = 0; i < n2; i++) // i vale 1
                {
                    int team1 = teams[n2 - i]; //time 1 = 9 (valor da posicao 9) --- 8
                    int team2 = teams[n2 + i + 1]; //time 2 = 10 ----- 11
                    results[team1, round] = team2; // linha 9, coluna 0 = 10 ------ linha 8 - 0 = 11
                    results[team2, round] = team1; //linha 10, coluna 0 = 9 ------- linha 11 - 0 = 8

                }
                // Set the team with the bye.
                results[teams[0], round] = BYE;

                // Rotate the array.
                RotateArray(teams);
            }

            return results;
        }

        // Rotate the entries one position.
        private void RotateArray(int[] teams)
        {
            int tmp = teams[teams.Length - 1];
            Array.Copy(teams, 0, teams, 1, teams.Length - 1);
            teams[0] = tmp;
        }

        private int[,] GenerateRoundRobinEven(int num_teams)
        {
            // Generate the result for one fewer teams.
            int[,] results = GenerateRoundRobinOdd(num_teams - 1);

            // Copy the results into a bigger array,
            // replacing the byes with the extra team.
            int[,] results2 = new int[num_teams, num_teams - 1];
            for (int team = 0; team < num_teams - 1; team++)
            {
                for (int round = 0; round < num_teams - 1; round++)
                {
                    if (results[team, round] == BYE)
                    {
                        // Change the bye to the new team.
                        results2[team, round] = num_teams - 1;
                        results2[num_teams - 1, round] = team;
                    }
                    else
                    {
                        results2[team, round] = results[team, round];
                    }
                }
            }
            return results2;
        }

        private int[,] GenerateRoundRobin(int num_teams)
        {
            if (num_teams % 2 == 0)
                return GenerateRoundRobinEven(num_teams);
            else
                return GenerateRoundRobinOdd(num_teams);
        }

        public List<int> retornarTimesCampeonato(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query =
                    (from timeCameponato in context.TIME_CAMPEONATO
                     where timeCameponato.idCampeonato == idCampeonato
                     select timeCameponato.idTime);
                return query.ToList();
            }
        }

        public int retornarIdRodada(int idCampeonato, int numeroRodada)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query =
                    (from rodada in context.RODADA
                     where rodada.idCampeonato == idCampeonato && rodada.numeroRodada == numeroRodada
                     select rodada.id);
                return query.FirstOrDefault();
            }
        }

        public void salvarJogo(JOGO jogo)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                context.JOGO.Add(jogo);
                context.SaveChanges();
            }
        }

        public void salvarRodadas(int idCampeonato, DateTime dataInicial)
        {
            int i = 0;

            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                for (i=0; i < 20; i++)
                {
                    RODADA rodada = new RODADA(idCampeonato, i + 1, dataInicial);
                    context.RODADA.Add(rodada);
                    context.SaveChanges();

                    dataInicial = dataInicial.AddDays(7);
                }
            }
        }

        public void comecar(int idCampeonato)
        {
            int[,] matriz;
            int auxIdTime;
            int auxIdTimeAdversario;
            int auxIdRodada;

            GerarRodadas a = new GerarRodadas();

            //Recebe os times vinculados ao campeonato.
            List<int> listTimesCampeonato = new List<int>();
            listTimesCampeonato = a.retornarTimesCampeonato(idCampeonato);

            if (listTimesCampeonato.Count == 20)
            {
                //Gera as rodadas e insere no banco
                a.salvarRodadas(idCampeonato, Convert.ToDateTime("2019-01-01"));

                //Gera os jogos para o campeonato.
                matriz = a.GenerateRoundRobin(20);

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //Linha do time 
                    auxIdTime = listTimesCampeonato[i];

                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        //Adversario
                        auxIdTimeAdversario = listTimesCampeonato[matriz[i, j]];

                        //Busca o id da roda x no compeonato y.
                        auxIdRodada = a.retornarIdRodada(idCampeonato, j + 1);

                        //Time casa auxIdTime
                        //Time fora auxIdTimeAdversario

                        //Salva na tabela JOGO.
                        JOGO jogo = new JOGO(auxIdRodada, idCampeonato, auxIdTime, 0, 0, auxIdTimeAdversario, 0, 0, "");
                        a.salvarJogo(jogo);
                    }
                }
            }
            else {
                if (listTimesCampeonato.Count == 0)
                {
                    MessageBox.Show("Nenhum time vinculado ao campeonato!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Campeonato precisa ter 20 time para gerar as rodadas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
        }

    }
}
