using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    class ValidarLogin
    {
        public bool LiberarLogin(USUARIO user)
        {           
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from userRegister in context.USUARIO
                            where userRegister.usuario1 == user.usuario1 && userRegister.senha == user.senha
                            select userRegister;

                var userLogin = query.FirstOrDefault<USUARIO>();

                if (userLogin != null) return true;
                else return false;
            }
        }
   
    }
}
