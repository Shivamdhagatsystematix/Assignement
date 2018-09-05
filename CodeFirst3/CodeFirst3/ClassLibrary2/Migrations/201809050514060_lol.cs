namespace ClassLibrary2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer_PersonalDetail", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer_PersonalDetail", "Role");
        }
    }
}
