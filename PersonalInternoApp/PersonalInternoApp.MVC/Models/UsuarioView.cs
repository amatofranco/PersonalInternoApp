using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalInternoApp.MVC.Models
{
    public class UsuarioView : ViewEntity
    {
        [Required(ErrorMessage = "Ingrese nombre de usuario")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese contraseña")]
        public string Contraseña { get; set; }
    }
}