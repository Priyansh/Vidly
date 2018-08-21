namespace VidlyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
        }
    }
}
