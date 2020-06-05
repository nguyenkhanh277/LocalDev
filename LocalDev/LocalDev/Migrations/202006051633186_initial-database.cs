namespace LocalDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthorityGroups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AuthorityGroupName = c.String(),
                        Sort = c.Int(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramFunctionAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProgramName = c.String(),
                        FunctionName = c.String(),
                        AuthorityGroupID = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupID)
                .Index(t => t.AuthorityGroupID);
            
            CreateTable(
                "dbo.UserAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserID = c.String(maxLength: 128),
                        AuthorityGroupID = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.AuthorityGroupID);
            
            CreateTable(
                "dbo.Barcodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PartNumberID = c.String(maxLength: 128),
                        PrintDate = c.DateTime(),
                        Line = c.String(),
                        Shift = c.String(),
                        SEQ = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartNumbers", t => t.PartNumberID)
                .Index(t => t.PartNumberID);
            
            CreateTable(
                "dbo.LanguageLibraries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Vietnamese = c.String(),
                        English = c.String(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PartNumbers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PartNo = c.String(),
                        Model = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramFunctionMasters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProgramName = c.String(),
                        FunctionName = c.String(),
                        Explanation = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Salt = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Gender = c.Int(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAuthorities", "UserID", "dbo.Users");
            DropForeignKey("dbo.Barcodes", "PartNumberID", "dbo.PartNumbers");
            DropForeignKey("dbo.UserAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropForeignKey("dbo.ProgramFunctionAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropIndex("dbo.Barcodes", new[] { "PartNumberID" });
            DropIndex("dbo.UserAuthorities", new[] { "AuthorityGroupID" });
            DropIndex("dbo.UserAuthorities", new[] { "UserID" });
            DropIndex("dbo.ProgramFunctionAuthorities", new[] { "AuthorityGroupID" });
            DropTable("dbo.Users");
            DropTable("dbo.ProgramFunctionMasters");
            DropTable("dbo.PartNumbers");
            DropTable("dbo.LanguageLibraries");
            DropTable("dbo.Barcodes");
            DropTable("dbo.UserAuthorities");
            DropTable("dbo.ProgramFunctionAuthorities");
            DropTable("dbo.AuthorityGroups");
        }
    }
}
