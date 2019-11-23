using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class FillComboCampeonato
    {
        public List<string> RetornarCampeonatos()
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from camp in context.CAMPEONATO
                            select camp.descricao;
                return query.ToList();
            }
        }
    }
}
