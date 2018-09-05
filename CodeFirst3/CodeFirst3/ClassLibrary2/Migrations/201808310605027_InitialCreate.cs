namespace ClassLibrary2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer_PersonalDetail",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        City = c.String(nullable: false),
                        ContactPerson = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customer_PersonalDetail");
        }
    }
}
