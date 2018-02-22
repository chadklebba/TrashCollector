namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "VacationStartDate", c => c.String());
            AddColumn("dbo.Customers", "VacationEndDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "VacationEndDate");
            DropColumn("dbo.Customers", "VacationStartDate");
        }
    }
}
