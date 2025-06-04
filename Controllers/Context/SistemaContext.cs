using Controllers.Map;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using Entidades;

namespace Controllers.Context
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=GABI; Database=dentista; Integrated Security=True;")
        {

        }

        public DbSet<Consulta> Consultas{ get; set; }
        public DbSet<Paciente> Pacientes{ get; set; }
        public DbSet<Dentista> Dentistas{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
    

    
}
