using PersonalInternoApp.Entities;
using System.Data.Entity;

namespace PersonalInternoApp.Database
{
    public partial class VittalDatabase : DbContext
    {
        public VittalDatabase()
            : base("name=VittalDatabaseConfig")
        {
        }

        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);
        }
    }
}
