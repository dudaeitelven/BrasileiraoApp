using System;
using System.Collections.Generic;
using BrasileiraoApp;
using BrasileiraoApp.Model;

public class Telas
{
    public Telas() { }

    public void intro()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("        BrasileirãoAPP");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }

    public int escolherOpcao()
    {
        int opcao = 0;
        Boolean passou = false;

        while (passou == false)
        {
            try
            {
                Console.WriteLine("Escolha sua opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                passou = true;
            }
            catch (Exception e)
            {
                passou = false;
                Console.WriteLine("Insira apenas números!");
            }
        }
        return opcao;
    }

    public int telaPrincipal()
    {
        this.intro();

        Console.WriteLine("1 - Para área restrita.");
        Console.WriteLine("2 - Para visualizar rodadas.");
        Console.WriteLine("3 - Para visualizar estatísticas.");
        Console.WriteLine("4 - Para visualizar a tabela de classificação.");

        Console.WriteLine("0 - Para sair.");

        return this.escolherOpcao();
    }

    public void fazerLogin()
    {
        ValidarLogin valida = new ValidarLogin();

        bool liberado = false;
        String usuario;
        String senha;

        Console.WriteLine("Informe seu usuário:");
        usuario = Console.ReadLine();
        Console.WriteLine("Informe sua senha:");
        senha = Console.ReadLine();

        USUARIO user = new USUARIO();
        user.usuario1 = usuario;
        user.senha = senha;

        liberado = valida.LiberarLogin(user);

        if (liberado)
        {
            Console.Clear();
            Console.WriteLine("Logado!");
            this.areaRestrita();
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorretos.");
        }
    }

    public void login()
    {
        int op = 1;

        this.intro();

        Console.WriteLine("----------Área Restrita----------");
        Console.WriteLine();
        Console.WriteLine("1 - Para fazer login.");
        Console.WriteLine("0 - Para sair da área restrita.");

        while (op != 0)
        {
            op = this.escolherOpcao();
            switch (op)
            {
                case 1:
                    this.fazerLogin();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
    public int selecionaCampeonato()
    {
        int i = 1;

        FillComboCampeonato fillCampeonatos = new FillComboCampeonato();
        List<string> fillCampeonatosList = new List<string>();

        fillCampeonatosList = fillCampeonatos.RetornarCampeonatos();

        Console.WriteLine("Selecione o campeonato");

        foreach (var lineListCampeonato in fillCampeonatosList)
        {
            Console.WriteLine(i++ + " - " + lineListCampeonato);
        }

        return this.escolherOpcao();
    }

    public int selecionaRodada(int idCampeonato)
    {
        FillComboRodadas rodadas = new FillComboRodadas();
        List<int> FillComboRodadas = new List<int>();

        Console.WriteLine("Selecione a rodada:");

        FillComboRodadas = rodadas.RetornarRodadas(idCampeonato);

        foreach (var lineListRodadas in FillComboRodadas)
        {
            Console.WriteLine(lineListRodadas);
        }

        return this.escolherOpcao();

    }

    public void visualizaRodadas()
    {
        int nroRodada;
        int idCampeonato;

        FillComboRodadas rodadas = new FillComboRodadas();
        List<int> FillComboRodadas = new List<int>();

        FillGridRodadas jogosRodadas = new FillGridRodadas();
        List<FillGridRodadas> listaJogosRodadas = new List<FillGridRodadas>();

        idCampeonato = this.selecionaCampeonato();

        nroRodada = this.selecionaRodada(idCampeonato);

        listaJogosRodadas = jogosRodadas.RetornarTimesRodadas(idCampeonato, nroRodada);

        foreach (var jogo in listaJogosRodadas)
        {
            Console.WriteLine("Rodada " + jogo.ResNumeroRodada + " - " + "Data: " + DateTime.Parse(jogo.ResDataRodada).ToString("dd-MM-yyyy"));
            Console.WriteLine("Time Casa: " +jogo.ResTimeCasa);
            Console.WriteLine("Time Visitante: " +jogo.ResTimeVisitante);
            Console.WriteLine();
        }

    }

    public void selecionaEstatisticas()
    {
        int opcao;
        int nroRodada;
        int idCampeonato;

        FillGridTabelaEstatistica tabelaEstatistica = new FillGridTabelaEstatistica();

        List<FillGridTabelaEstatistica> listaEstatistica = new List<FillGridTabelaEstatistica>();
        

        idCampeonato = this.selecionaCampeonato();
        nroRodada = this.selecionaRodada(idCampeonato);

        Console.WriteLine("1 - Para melhor ataque - Mais fez gols");
        Console.WriteLine("2 - Para pior ataque - Menos fez gols");
        Console.WriteLine("3 - Para melhor defesa - Menos faltas");
        Console.WriteLine("4 - Para pior defesa - Mais faltas");
        Console.WriteLine("Selecione a estatística:");

        opcao = this.escolherOpcao();

        switch (opcao)
        {
            case 1:
                listaEstatistica = tabelaEstatistica.RetornarEstatisticaMaisGols(idCampeonato, nroRodada);
                foreach (var estatistica in listaEstatistica)
                {
                    //Console.WriteLine("Time: " + estatistica.ResTime + " gols: " + estatistica.ResSaldoGols);
                    Console.WriteLine("Time: {0} gols: {1}",estatistica.ResTime,estatistica.ResSaldoGols);
                    
                    Console.WriteLine("Time: {0} /t gols: {1}", estatistica.ResTime, estatistica.ResSaldoGols);
                }
                break;
            case 2:
                listaEstatistica = tabelaEstatistica.RetornarEstatisticaMenosGols(idCampeonato, nroRodada);
                foreach (var estatistica in listaEstatistica)
                {
                    Console.WriteLine("Time: " + estatistica.ResTime + " gols: " + estatistica.ResSaldoGols);
                }
                break;
            case 3:
                listaEstatistica = tabelaEstatistica.RetornarEstatisticaMenosFaltas(idCampeonato, nroRodada);
                foreach (var estatistica in listaEstatistica)
                {
                    Console.WriteLine("Time: " + estatistica.ResTime + " faltas: " + estatistica.ResTotalFaltas);
                }
                break;
            case 4:
                listaEstatistica = tabelaEstatistica.RetornarEstatisticaMaisFaltas(idCampeonato, nroRodada);
                foreach (var estatistica in listaEstatistica)
                {
                    Console.WriteLine("Time: " + estatistica.ResTime + " faltas: " + estatistica.ResTotalFaltas);
                }
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }

    public void cadastroTime()
    {
        String nome;
        String historia;
        int ano;
        int nroTorcedores;
        int nroTitulos;

        Console.WriteLine("Insira o nome do time:");
        nome = Console.ReadLine();

        Console.WriteLine("Insira a história do time:");
        historia = Console.ReadLine();

        Console.WriteLine("Insira o ano de fundaçao do time:");
        ano = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira a quantidade média de torcedores");
        nroTorcedores = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira o número de títulos do time:");
        nroTitulos = Convert.ToInt32(Console.ReadLine());
    }

    public void cadastroCampeonato()
    {
        String nome;
        String historia;
        int ano;
        int qtdTimes;

        Console.WriteLine("Insira o nome do campeonato:");
        nome = Console.ReadLine();

        Console.WriteLine("Insira a história do campeonato:");
        historia = Console.ReadLine();

        Console.WriteLine("Insira o ano do campeonato:");
        ano = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira a quantidade de times do campeonato:");
        qtdTimes = Convert.ToInt32(Console.ReadLine());

    }

    public void areaRestrita()
    {
        int op;
        Console.WriteLine("1 - Para cadastrar times.");
        Console.WriteLine("2 - Para cadastrar campeonatos.");
        op = this.escolherOpcao();

        switch (op)
        {
            case 1:
                this.cadastroTime();
                break;
            case 2:
                this.cadastroCampeonato();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    public void visualizaClassificacao()
    {
        this.selecionaCampeonato();


    }


}
