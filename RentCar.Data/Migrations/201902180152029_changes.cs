namespace RentCar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehiculo", "Descripcion", c => c.String(maxLength: 50));
            AddColumn("dbo.Modelo", "Descripcion", c => c.String(maxLength: 50, nullable: false));
            DropColumn("dbo.Modelo", "Año");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modelo", "Año", c => c.Int(nullable: false));
            DropColumn("dbo.Modelo", "Descripcion");
            DropColumn("dbo.Vehiculo", "Descripcion");
        }
    }
}
