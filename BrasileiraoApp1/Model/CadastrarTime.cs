using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class CadastrarTime
    {
        public void SalvarTime(TIME time)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                context.TIME.Add(time);
                context.SaveChanges();
            }
        }

    }
}
