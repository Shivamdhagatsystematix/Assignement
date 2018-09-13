namespace memberships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _45 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Item", "IsFree", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Item", "IsFree", c => c.Int(nullable: false));
        }
    }
}
