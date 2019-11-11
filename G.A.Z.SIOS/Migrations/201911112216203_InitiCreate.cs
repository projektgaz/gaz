namespace G.A.Z.SIOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitiCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventViewModels", "Udzial_count", c => c.Int(nullable: false));
            AddColumn("dbo.EventViewModels", "Zainteresowani_count", c => c.Int(nullable: false));
            AddColumn("dbo.EventViewModels", "Image_id", c => c.Int(nullable: false));
            AlterColumn("dbo.EventViewModels", "Rodzaj", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventViewModels", "Rodzaj", c => c.String(nullable: false));
            DropColumn("dbo.EventViewModels", "Image_id");
            DropColumn("dbo.EventViewModels", "Zainteresowani_count");
            DropColumn("dbo.EventViewModels", "Udzial_count");
        }
    }
}
