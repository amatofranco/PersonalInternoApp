using PersonalInternoApp.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInternoApp.Logic
{
    public class UsuariosLogic : BusinessLogic, IAuthenticationLogic
    {
        public bool Authenticate(string user, string password)
        {

            var usuario = this.context.Usuarios.Where(u => u.Nombre == user && u.Contraseña == password).FirstOrDefault();

            return usuario != null;
        }
    }
}
