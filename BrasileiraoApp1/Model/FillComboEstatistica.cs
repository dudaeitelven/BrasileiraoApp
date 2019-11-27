using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillComboEstatistica
    {
        public List<string> RetornarEstatisticas()
        {
            List<string> fillRodadas = new List<string>();

            fillRodadas.Add("Time que mais fez gols");
            fillRodadas.Add("Time que menos fez gols");
            fillRodadas.Add("Time que mais fez faltas");
            fillRodadas.Add("Time que menos fez faltas");

            return fillRodadas;
        }
    }
}
