namespace RentCar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Apellido = c.String(nullable: false, maxLength: 30),
                        Cedula = c.String(nullable: false, maxLength: 30),
                        TarjetaCredito = c.Int(nullable: false),
                        LimiteCredito = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoPersonaId = c.Int(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoPersona", t => t.TipoPersonaId)
                .Index(t => t.TipoPersonaId);
            
            CreateTable(
                "dbo.TipoPersona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        Apellido = c.String(nullable: false, maxLength: 30),
                        Cedula = c.String(nullable: false, maxLength: 30),
                        TandaLaborId = c.Int(nullable: false),
                        PorcientoComision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaIngreso = c.DateTime(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TandaLabor", t => t.TandaLaborId)
                .Index(t => t.TandaLaborId);
            
            CreateTable(
                "dbo.TandaLabor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstatusRenta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inspeccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehiculoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                        CantidadCombustible = c.String(nullable: false, maxLength: 15),
                        EstaRayado = c.Boolean(nullable: false),
                        TieneGomaRepuesta = c.Boolean(nullable: false),
                        TieneGato = c.Boolean(nullable: false),
                        TieneCristalRoto = c.Boolean(nullable: false),
                        EstadoGomaDelanteraDerecha = c.Int(nullable: false),
                        EstadoGomaDelanteraIzquierda = c.Int(nullable: false),
                        EstadoGomaTraseraDerecha = c.Int(nullable: false),
                        EstadoGomaTraseraIzquierda = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoId)
                .ForeignKey("dbo.Estado", t => t.EstadoId)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoId)
                .Index(t => t.VehiculoId)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroChasis = c.String(nullable: false, maxLength: 15),
                        NumeroMotor = c.String(nullable: false, maxLength: 15),
                        NumeroPlaca = c.String(nullable: false, maxLength: 15),
                        TipoVehiculoId = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        CombustibleId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        TipoCombustible_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.EstadoId)
                .ForeignKey("dbo.Marca", t => t.MarcaId)
                .ForeignKey("dbo.Modelo", t => t.ModeloId)
                .ForeignKey("dbo.TipoCombustible", t => t.TipoCombustible_Id)
                .ForeignKey("dbo.TipoVehiculo", t => t.TipoVehiculoId)
                .Index(t => t.TipoVehiculoId)
                .Index(t => t.MarcaId)
                .Index(t => t.ModeloId)
                .Index(t => t.EstadoId)
                .Index(t => t.TipoCombustible_Id);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Año = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marca", t => t.MarcaId)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.TipoCombustible",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoVehiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProcesoRenta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpleadoId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        EstatusRentaId = c.Int(nullable: false),
                        FechaRenta = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        MontoPorDia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CantidadDias = c.Int(nullable: false),
                        MontoAPagar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comentario = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoId)
                .ForeignKey("dbo.EstatusRenta", t => t.EstatusRentaId)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoId)
                .Index(t => t.EmpleadoId)
                .Index(t => t.VehiculoId)
                .Index(t => t.ClienteId)
                .Index(t => t.EstatusRentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcesoRenta", "VehiculoId", "dbo.Vehiculo");
            DropForeignKey("dbo.ProcesoRenta", "EstatusRentaId", "dbo.EstatusRenta");
            DropForeignKey("dbo.ProcesoRenta", "EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.ProcesoRenta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Inspeccion", "VehiculoId", "dbo.Vehiculo");
            DropForeignKey("dbo.Vehiculo", "TipoVehiculoId", "dbo.TipoVehiculo");
            DropForeignKey("dbo.Vehiculo", "TipoCombustible_Id", "dbo.TipoCombustible");
            DropForeignKey("dbo.Vehiculo", "ModeloId", "dbo.Modelo");
            DropForeignKey("dbo.Modelo", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Vehiculo", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Vehiculo", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.Inspeccion", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.Inspeccion", "EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.Inspeccion", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Empleado", "TandaLaborId", "dbo.TandaLabor");
            DropForeignKey("dbo.Cliente", "TipoPersonaId", "dbo.TipoPersona");
            DropIndex("dbo.ProcesoRenta", new[] { "EstatusRentaId" });
            DropIndex("dbo.ProcesoRenta", new[] { "ClienteId" });
            DropIndex("dbo.ProcesoRenta", new[] { "VehiculoId" });
            DropIndex("dbo.ProcesoRenta", new[] { "EmpleadoId" });
            DropIndex("dbo.Modelo", new[] { "MarcaId" });
            DropIndex("dbo.Vehiculo", new[] { "TipoCombustible_Id" });
            DropIndex("dbo.Vehiculo", new[] { "EstadoId" });
            DropIndex("dbo.Vehiculo", new[] { "ModeloId" });
            DropIndex("dbo.Vehiculo", new[] { "MarcaId" });
            DropIndex("dbo.Vehiculo", new[] { "TipoVehiculoId" });
            DropIndex("dbo.Inspeccion", new[] { "EstadoId" });
            DropIndex("dbo.Inspeccion", new[] { "EmpleadoId" });
            DropIndex("dbo.Inspeccion", new[] { "ClienteId" });
            DropIndex("dbo.Inspeccion", new[] { "VehiculoId" });
            DropIndex("dbo.Empleado", new[] { "TandaLaborId" });
            DropIndex("dbo.Cliente", new[] { "TipoPersonaId" });
            DropTable("dbo.ProcesoRenta");
            DropTable("dbo.TipoVehiculo");
            DropTable("dbo.TipoCombustible");
            DropTable("dbo.Modelo");
            DropTable("dbo.Marca");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Inspeccion");
            DropTable("dbo.EstatusRenta");
            DropTable("dbo.Estado");
            DropTable("dbo.TandaLabor");
            DropTable("dbo.Empleado");
            DropTable("dbo.TipoPersona");
            DropTable("dbo.Cliente");
        }
    }
}
