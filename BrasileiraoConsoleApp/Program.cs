
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
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        view.fazerLogin();
                        break;
                    case 2:
                        Console.Clear();
                        view.visualizaRodadas();
                        break;
                    case 3:
                        Console.Clear();
                        view.selecionaEstatisticas();
                        break;
                    case 4:
                        Console.Clear();
                        view.visualizaClassificacao();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
