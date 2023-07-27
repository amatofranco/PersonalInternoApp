using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalInternoApp.MVC.Models
{
    public class EmpleadoView : ViewEntity
    {

        public int? EmpleadoID { get; set; }


        [Required(ErrorMessage = "Ingrese un apellido")]
        [StringLength(15, ErrorMessage = "El maximo de caracteres es 15")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre")]
        [StringLength(15, ErrorMessage = "El maximo de caracteres es 15")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese un DNI")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "Ingrese un Email")]
        [StringLength(30, ErrorMessage = "El maximo de caracteres es 30")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese un Celular")]
        public int Celular { get; set; }
    }
}