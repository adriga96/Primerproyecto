using Microsoft.EntityFrameworkCore;
using MiPrimeraApp.Dominio;

namespace MiPrimeraApp.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=Hospital2207208; Data Source=LAPTOP-PLLBCL78; Integrated Security=true");
                        /*
                        initial catalog: nombre de la base de datos
                        data source: nombre del servidor de la base de datos
                        integrated security: seguridad con la misma configuracion del inicio de sesion
                        */
            }
        }
    }
}