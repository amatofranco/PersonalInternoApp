using PersonalInternoApp.Database;
using PersonalInternoApp.Entities;
using PersonalInternoApp.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PersonalInternoApp.Logic
{
    public class EmpleadosLogic : BusinessLogic, IABMLogic<Empleado>
    {
        public List<Empleado> GetAll()
        {
            return context.Empleados.ToList();
        }

        public void Add(Empleado entity)
        {
            context.Empleados.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int ID)
        {
            var entity = context.Empleados.Where(e => e.EmpleadoID == ID).FirstOrDefault();

            if (entity != null) {

                context.Empleados.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Empleado entity)
        {
            var entityUpdate = context.Empleados.Where(e => e.EmpleadoID == entity.EmpleadoID).FirstOrDefault();

            if (entityUpdate != null)
            {
                entityUpdate.Nombre = entity.Nombre;
                entityUpdate.Apellido = entity.Apellido;
                entityUpdate.Celular = entity.Celular;
                entityUpdate.Dni = entity.Dni;
                entityUpdate.Email = entity.Email;

                context.SaveChanges();
            }

        }

        public Empleado GetByID(int ID)
        {
            return context.Empleados.Where(e => e.EmpleadoID == ID).FirstOrDefault();
        }
    }
}
