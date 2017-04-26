namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShortDescAddedDateToTodo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "ShortDesc", c => c.String());
            AddColumn("dbo.Todoes", "AddeddDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "AddeddDate");
            DropColumn("dbo.Todoes", "ShortDesc");
        }
    }
}
