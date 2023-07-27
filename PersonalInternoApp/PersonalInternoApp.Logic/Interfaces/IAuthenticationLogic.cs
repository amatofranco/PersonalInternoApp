using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInternoApp.Logic.Interfaces
{
    public interface IAuthenticationLogic
    {
        bool Authenticate(string user, string password);
    }
}
