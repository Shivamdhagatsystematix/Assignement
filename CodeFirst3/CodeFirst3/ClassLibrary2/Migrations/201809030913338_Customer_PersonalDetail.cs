namespace ClassLibrary2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer_PersonalDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer_PersonalDetail", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer_PersonalDetail", "Password");
        }
    }
}
