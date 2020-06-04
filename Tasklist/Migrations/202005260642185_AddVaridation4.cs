namespace Tasklist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVaridation4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
           AlterColumn("dbo.Tasks", "Content", c => c.String());
        }
    }
}
