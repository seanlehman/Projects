namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLogEntriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogEntryEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Application = c.String(maxLength: 255),
                        Level = c.String(maxLength: 255),
                        Logger = c.String(),
                        Message = c.String(),
                        MachineName = c.String(),
                        UserName = c.String(maxLength: 255),
                        Thread = c.String(),
                        Exception = c.String(),
                        DateCreated = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        IsStarred = c.Boolean(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.NoteId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ElevenNoteUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ElevenNoteUser", t => t.ElevenNoteUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ElevenNoteUser_Id);
            
            CreateTable(
                "dbo.ElevenNoteUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ElevenNoteUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ElevenNoteUser", t => t.ElevenNoteUser_Id)
                .Index(t => t.ElevenNoteUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ElevenNoteUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ElevenNoteUser", t => t.ElevenNoteUser_Id)
                .Index(t => t.ElevenNoteUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ElevenNoteUser_Id", "dbo.ElevenNoteUser");
            DropForeignKey("dbo.IdentityUserLogin", "ElevenNoteUser_Id", "dbo.ElevenNoteUser");
            DropForeignKey("dbo.IdentityUserClaim", "ElevenNoteUser_Id", "dbo.ElevenNoteUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropIndex("dbo.IdentityUserLogin", new[] { "ElevenNoteUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ElevenNoteUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ElevenNoteUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ElevenNoteUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Notes");
            DropTable("dbo.LogEntryEntity");
        }
    }
}
