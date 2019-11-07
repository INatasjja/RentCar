namespace RentCar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifica_campo_tarjCredito_tbl_cliente_a_string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "TarjetaCredito", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "TarjetaCredito", c => c.Int(nullable: false));
        }
    }
}
