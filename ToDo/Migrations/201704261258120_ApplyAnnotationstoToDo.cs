namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationstoToDo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Todoes", "ShortDesc", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "ShortDesc", c => c.String());
            AlterColumn("dbo.Todoes", "Name", c => c.String());
        }
    }
}
