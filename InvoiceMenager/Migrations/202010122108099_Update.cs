namespace InvoiceMenager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "Comments", c => c.String());
            DropColumn("dbo.Invoices", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Invoices", "Comments");
        }
    }
}
