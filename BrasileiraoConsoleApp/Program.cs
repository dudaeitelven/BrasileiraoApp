
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrasileiraoConsoleApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Telas view = new Telas();

            view.selecionaCampeonato();
            view.telaPrincipal();
            Console.ReadKey();
            
        }
    }
}
