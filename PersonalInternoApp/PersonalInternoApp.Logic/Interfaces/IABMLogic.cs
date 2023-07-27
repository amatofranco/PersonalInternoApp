using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInternoApp.Logic.Interfaces
{
    public interface IABMLogic<T> : IBusinessLogic
    {
        List<T> GetAll();

        T GetByID(int ID);

        void Add(T entity);

        void Update(T entity);

        void Delete(int ID);
    }
}
