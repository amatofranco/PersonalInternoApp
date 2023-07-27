using PersonalInternoApp.Database;
using PersonalInternoApp.Entities;
using PersonalInternoApp.Logic;
using PersonalInternoApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalInternoApp.MVC.Controllers
{
    public class EmpleadosController : Controller
    {
        EmpleadosLogic empleadosLogic = new EmpleadosLogic();

        public ActionResult Index()
        {
            var empleados = empleadosLogic.GetAll();

            return View(empleados);
        }

        public ActionResult InsertUpdate(int? id)
        {

            EmpleadoView empleadoView = null;

            if (id != null)
            {
                try
                {
                    Empleado empleado = empleadosLogic.GetByID((int)id);

                    empleadoView = new EmpleadoView
                    {
                        EmpleadoID = empleado.EmpleadoID,
                        Nombre = empleado.Nombre,
                        Apellido = empleado.Apellido,
                        Celular = empleado.Celular,
                        Dni = empleado.Dni,
                        Email = empleado.Email
                    };
                }

                catch (Exception ex)
                {
                    return RedirectToAction("Index", "Error");

                }
            }


            return View(empleadoView);
        }

        [HttpPost]

        public ActionResult InsertUpdate(EmpleadoView empleadoView)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                var empleadoEntiy = new Empleado
                {
                    Nombre = empleadoView.Nombre,
                    Apellido = empleadoView.Apellido,
                    Celular = empleadoView.Celular,
                    Dni = empleadoView.Dni,
                    Email = empleadoView.Email
                };

                if (empleadoView.EmpleadoID == null)
                {
                    empleadosLogic.Add(empleadoEntiy);
                }

                else
                {
                    empleadoEntiy.EmpleadoID = (int)empleadoView.EmpleadoID;

                    empleadosLogic.Update(empleadoEntiy);
                }

                return RedirectToAction("Index");

            }

            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");

            }
        }
    }
}