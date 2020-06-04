namespace Tasklist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVaridation3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Content", c => c.String());
            DropColumn("dbo.Tasks", "Task");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Task", c => c.String());
            DropColumn("dbo.Tasks", "Content");
        }
    }
}
