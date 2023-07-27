using PersonalInternoApp.Logic;
using PersonalInternoApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalInternoApp.MVC.Controllers
{
    public class LoginController : Controller
    {
        UsuariosLogic usuariosLogic = new UsuariosLogic();

        public ActionResult Login(UsuarioView usuarioView)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");

            }
            try
            {
               var autenticado = usuariosLogic.Authenticate(usuarioView.Nombre, usuarioView.Contraseña);

                if (autenticado)
                {
                    return RedirectToAction("Index", "Empleados");

                }
                else
                {
                    return RedirectToAction("Error", "Login");

                }

            }
            catch (Exception ex)
            {
               return RedirectToAction("Index", "Error");
            }

        }

        public ActionResult Error()
        {
            return View();
        }
    }
}