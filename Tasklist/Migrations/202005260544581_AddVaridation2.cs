namespace Tasklist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVaridation2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Task", c => c.String());
            DropColumn("dbo.Tasks", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Content", c => c.String());
            DropColumn("dbo.Tasks", "Task");
        }
    }
}
