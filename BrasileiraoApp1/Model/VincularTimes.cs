using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class VincularTimes
    {
        private int resIdTime;
        private string resTime;

        public string ResTime { get => resTime; set => resTime = value; }
        public int ResIdTime { get => resIdTime; set => resIdTime = value; }

        public List<VincularTimes> CarregarVinculados(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from timeCampeonato in context.TIME_CAMPEONATO
                            join time in context.TIME on timeCampeonato.idTime equals time.id
                            where timeCampeonato.idCampeonato == idCampeonato 
                            orderby time.nome 
                            select new VincularTimes
                            {
                                resIdTime = time.id,
                                resTime = time.nome
                            };

                return query.ToList();

            }
        }

        public List<VincularTimes> CarregarNaoVinculados(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from time in context.TIME
                            where !(
                                from timeCampeonato in context.TIME_CAMPEONATO
                                where timeCampeonato.idCampeonato == idCampeonato
                                select timeCampeonato.idTime).Contains(time.id)
                            orderby time.nome
                            select new VincularTimes
                            {
                                resIdTime = time.id,
                                resTime = time.nome
                            };

                return query.ToList();
            }
        }
    }
}
