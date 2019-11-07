using System.Data.Entity.ModelConfiguration.Conventions;
using RentCar.Data.Entidades;

namespace RentCar.Data
{
    using System.Data.Entity;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<EstatusRenta> EstatusRenta { get; set; }
        public DbSet<Inspeccion> Inspeccion { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<ProcesoRenta> ProcesoRenta { get; set; }
        public DbSet<TandaLabor> TandaLabor { get; set; }
        public DbSet<TipoCombustible> TipoCombustible { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}