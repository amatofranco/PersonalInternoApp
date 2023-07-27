using PersonalInternoApp.Database;
using PersonalInternoApp.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInternoApp.Logic
{
    public class BusinessLogic : IBusinessLogic

    {
        protected readonly VittalDatabase context;

        public BusinessLogic ()
        {
            this.context = new VittalDatabase();
        }
    }
}
