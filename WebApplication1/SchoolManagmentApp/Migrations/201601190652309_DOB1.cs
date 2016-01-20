namespace SchoolManagmentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DOB");
        }
    }
}
