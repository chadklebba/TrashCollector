namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datedropdown : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickupDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PickupDate");
        }
    }
}
