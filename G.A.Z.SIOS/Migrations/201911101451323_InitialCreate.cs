namespace G.A.Z.SIOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventViewModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Miejsce = c.String(nullable: false),
                        Cena_wejsciowki = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ID_organizator = c.Int(nullable: false),
                        Rodzaj = c.String(nullable: false),
                        Opinia_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventViewModels");
        }
    }
}
