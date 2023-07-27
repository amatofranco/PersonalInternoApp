namespace PersonalInternoApp.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Empleados")]
    public partial class Empleado : BusinessEntity
    {
        public int EmpleadoID { get; set; }

        [Required]
        [StringLength(15)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(15)]
        public string Nombre { get; set; }

        public int Dni { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        public int Celular { get; set; }
    }
}
