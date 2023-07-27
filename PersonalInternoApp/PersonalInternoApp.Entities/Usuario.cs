namespace PersonalInternoApp.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Usuario : BusinessEntity
    {
        [Key]
        public int UsuarioID { get; set; }

        [StringLength(15)]
        public string Nombre { get; set; }

        [StringLength(15)]
        public string Contraseña { get; set; }
    }
}
