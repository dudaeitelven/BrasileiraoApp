using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillComboRodadas
    {
        public List<int> RetornarRodadas(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from rodada in context.RODADA
                            where rodada.idCampeonato == idCampeonato
                            select rodada.numeroRodada;
                return query.ToList();
            }
        }
    }
}
