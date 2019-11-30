using System;
using System.Collections.Generic;
using BrasileiraoApp;
using BrasileiraoApp.Model;

public class Telas
{
	public Telas(){}

    public void intro()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("        BrasileirãoAPP");
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }

    public int escolherOpcao()
    {
        int opcao=0;
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
                //throw e;
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

    public void dadosCriarUsuario()
    {
        String dtNasc;
        String email;
        String usuario;
        String senha;
        
        //USUARIO u = new USUARIO();

        this.intro();
        
        Console.WriteLine("Informe sua data de nascimento:");
        dtNasc = Console.ReadLine();

        Console.WriteLine("Informe seu E-mail:");
        email = Console.ReadLine();

        Console.WriteLine("Informe seu nome de usuário:");
        usuario = Console.ReadLine();

        Console.WriteLine("Informe sua senha:");
        senha = Console.ReadLine();
    }

    public Boolean dadosFazerLogin()
    {
        ValidarLogin valida = new ValidarLogin();

        bool liberado = false;
        String usuario;
        String senha;

        Console.WriteLine("Informe seu usuário:");
        usuario = Console.ReadLine();
        Console.WriteLine("Informe sua senha:");
        senha = Console.ReadLine();

        USUARIO user = new USUARIO(usuario, senha);
        liberado = valida.LiberarLogin(user);

        if (liberado)
        {
            //Logou
        }
        else
        {
            //Nao
        }

        /*
         fazer a verificacao no banco do usuario
         logou = true;
         
         */



        return logou;
    }

    public Boolean login()
    {
        int op =1;
        Boolean logado = false;

        this.intro();
        
        Console.WriteLine("----------Área Restrita----------");
        Console.WriteLine();
        Console.WriteLine("1 - Para criar usuário.");
        Console.WriteLine("2 - Para fazer login.");
        Console.WriteLine("0 - Para sair da área restrita.");

        while (op!=0)
        {
            op = this.escolherOpcao();
            switch (op)
            {   
                case 1:
                    this.dadosCriarUsuario();
                    break;
                case 2:
                    logado = this.dadosFazerLogin();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        return logado;
    }
    public void selecionaCampeonato()
    {
        FillComboCampeonato fillCampeonatos = new FillComboCampeonato();
        List<string> fillCampeonatosList = new List<string>();

        fillCampeonatosList = fillCampeonatos.RetornarCampeonatos();

        Console.WriteLine("Selecione o campeonato");

        foreach (var lineListCampeonato in fillCampeonatosList)
        {
            Console.WriteLine(lineListCampeonato);
        }

        this.escolherOpcao();
    }

    

    public void selecionaRodadas()
    {
        FillComboRodadas rodadas = new FillComboRodadas();
        List<String> FillComboRodadas = new List<String>();

        this.selecionaCampeonato();

        Console.WriteLine("Selecione a rodada:");
        //listar as rodadas

        foreach (var lineListRodadas in FillComboRodadas)
        {
            Console.WriteLine(lineListRodadas);
        }
        this.escolherOpcao();
    }

    public void selecionaEstatisticas()
    {
        this.selecionaCampeonato();
        Console.WriteLine("1 - Para melhor ataque.");
        Console.WriteLine("2 - Para pior ataque.");
        Console.WriteLine("3 - Para melhor defesa.");
        Console.WriteLine("4 - Para pior defesa.");
        Console.WriteLine("Selecione a estatística:");
        this.escolherOpcao();

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
