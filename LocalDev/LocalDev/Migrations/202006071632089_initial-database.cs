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
                "dbo.Machines",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MachineNo = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Molds",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MoldNo = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
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
                "dbo.RegistBarcodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PartNo = c.String(),
                        RegistDate = c.DateTime(),
                        MachineNo = c.String(),
                        ShiftNo = c.String(),
                        MoldNo = c.String(),
                        SEQ = c.String(),
                        Barcode = c.String(),
                        UserID = c.String(maxLength: 128),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.ScanBarcodeDetails",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ScanBarcodeId = c.String(),
                        ProducedDate = c.DateTime(),
                        Barcode = c.String(),
                        PartNo = c.String(),
                        ShiftNo = c.String(),
                        MachineNo = c.String(),
                        UserID = c.String(),
                        ResultStatus = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ScanBarcodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        WorkOrder = c.String(),
                        PartNo = c.String(),
                        Model = c.String(),
                        ExpectedDeliveryDate = c.DateTime(),
                        Quantity = c.Double(nullable: false),
                        UserID = c.String(maxLength: 128),
                        ProductionStatus = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ShiftNo = c.String(),
                        Note = c.String(),
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
            DropForeignKey("dbo.ScanBarcodes", "UserID", "dbo.Users");
            DropForeignKey("dbo.RegistBarcodes", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropForeignKey("dbo.ProgramFunctionAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropIndex("dbo.ScanBarcodes", new[] { "UserID" });
            DropIndex("dbo.RegistBarcodes", new[] { "UserID" });
            DropIndex("dbo.UserAuthorities", new[] { "AuthorityGroupID" });
            DropIndex("dbo.UserAuthorities", new[] { "UserID" });
            DropIndex("dbo.ProgramFunctionAuthorities", new[] { "AuthorityGroupID" });
            DropTable("dbo.Users");
            DropTable("dbo.Shifts");
            DropTable("dbo.ScanBarcodes");
            DropTable("dbo.ScanBarcodeDetails");
            DropTable("dbo.RegistBarcodes");
            DropTable("dbo.ProgramFunctionMasters");
            DropTable("dbo.PartNumbers");
            DropTable("dbo.Molds");
            DropTable("dbo.Machines");
            DropTable("dbo.LanguageLibraries");
            DropTable("dbo.UserAuthorities");
            DropTable("dbo.ProgramFunctionAuthorities");
            DropTable("dbo.AuthorityGroups");
        }
    }
}
