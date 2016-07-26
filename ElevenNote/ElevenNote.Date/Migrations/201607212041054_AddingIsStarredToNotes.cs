namespace ElevenNote.Date.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIsStarredToNotes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "IsStarred", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "IsStarred");
        }
    }
}
