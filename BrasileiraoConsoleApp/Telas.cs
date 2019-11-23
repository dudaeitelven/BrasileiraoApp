using System;
using System.Collections.Generic;
using BrasileiraoApp.Model;


public class Telas
{
	public Telas(){}

    public void intro()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("        BrasileirãoAPP");
        Console.WriteLine("-----------------------------");
    }

    public void escolherOpcao()
    {
        Console.WriteLine("Escolha sua opção:");

    }

    public void selecionaCampeonato()
    {

        FillComboCampeonato fillCampeonatos = new FillComboCampeonato();
        List<string> fillCampeonatosList = new List<string>();

        fillCampeonatosList = fillCampeonatos.RetornarCampeonatos();

        Console.WriteLine("Selecione o campeonato");

        foreach (var lineListRodadas in fillCampeonatosList)
        {
            Console.WriteLine(lineListRodadas);
        }

        //listar os campeonatos

    }

    public void telaPrincipal()
    {
        Console.WriteLine("1 - Para visualizar rodadas.");
        Console.WriteLine("2 - Para visualizar estatísticas.");
        Console.WriteLine("3 - Para visualizar a tabela de classificação.");
        Console.WriteLine("4 - Para área restrita.");
        this.escolherOpcao();
    }

    public void selecionaRodadas()
    {
        this.selecionaCampeonato();

        Console.WriteLine("Selecione a rodada:");
        //listar as rodadas
    }

    public void selecionaEstatisticas()
    {
        this.selecionaCampeonato();
        Console.WriteLine("1 - Para melhor ataque.");
        Console.WriteLine("2 - Para pior ataque.");
        Console.WriteLine("3 - Para melhor defesa.");
        Console.WriteLine("4 - Para pior defesa.");
        Console.WriteLine("Selecione a estatística:");

    }

    public void visualizaClassificacao()
    {
        this.selecionaCampeonato();


    }


}
