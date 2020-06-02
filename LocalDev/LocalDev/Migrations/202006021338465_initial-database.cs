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
                        Id = c.Int(nullable: false, identity: true),
                        AuthorityGroupName = c.String(),
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
                        AuthorityGroupID = c.Int(),
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
                "dbo.UserAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserID = c.String(),
                        AuthorityGroupID = c.Int(),
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
            DropTable("dbo.Users");
            DropTable("dbo.UserAuthorities");
            DropTable("dbo.ProgramFunctionMasters");
            DropTable("dbo.ProgramFunctionAuthorities");
            DropTable("dbo.AuthorityGroups");
        }
    }
}
