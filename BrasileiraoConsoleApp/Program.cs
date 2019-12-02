
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrasileiraoConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            Telas view = new Telas();

            while (op != 0)
            {
                op = view.telaPrincipal();
                Console.Clear();
                switch (op)
                {
                    case 1:
                        view.fazerLogin();
                        break;
                    case 2:
                        view.visualizaRodadas();
                        break;
                    case 3:
                        view.selecionaEstatisticas();
                        break;
                    case 4:
                        view.visualizaClassificacao();
                        break;
                    case 0:
                        Console.WriteLine("Programa encerrado!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
