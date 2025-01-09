namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateemployeedepartmentsize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String());
        }
    }
}
