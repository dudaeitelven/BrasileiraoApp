using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class CadastrarCampeonato
    {
        public void SalvarCampeonato(CAMPEONATO campeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                context.CAMPEONATO.Add(campeonato);
                context.SaveChanges();
            }
        }

    }
}
