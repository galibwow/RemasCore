namespace RemasCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendence",
                c => new
                    {
                        AtId = c.Int(nullable: false, identity: true),
                        Incoming = c.DateTime(nullable: false),
                        OutGoing = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AtId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Designation = c.String(),
                        NationId = c.String(),
                        EmployeeId = c.String(),
                        DOB = c.DateTime(nullable: false),
                        EmployeeEmail = c.String(),
                        Atttendence_AtId = c.Int(),
                        performance_PerformanceId = c.Int(),
                    })
                .PrimaryKey(t => t.EId)
                .ForeignKey("dbo.Attendence", t => t.Atttendence_AtId)
                .ForeignKey("dbo.Perfomance", t => t.performance_PerformanceId)
                .Index(t => t.Atttendence_AtId)
                .Index(t => t.performance_PerformanceId);
            
            CreateTable(
                "dbo.Perfomance",
                c => new
                    {
                        PerformanceId = c.Int(nullable: false, identity: true),
                        IssueFund = c.String(),
                        project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.PerformanceId)
                .ForeignKey("dbo.Projects", t => t.project_ProjectId)
                .Index(t => t.project_ProjectId);
            
            CreateTable(
                "dbo.PerformanceStatus",
                c => new
                    {
                        PerformanceStatusId = c.Int(nullable: false, identity: true),
                        PerformanceStatusname = c.String(),
                        performence_PerformanceId = c.Int(),
                    })
                .PrimaryKey(t => t.PerformanceStatusId)
                .ForeignKey("dbo.Perfomance", t => t.performence_PerformanceId)
                .Index(t => t.performence_PerformanceId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        ProjectReciveDate = c.DateTime(nullable: false),
                        ProjectDeliverDate = c.DateTime(nullable: false),
                        EstimationTime = c.DateTime(nullable: false),
                        NumberOfTalentUse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Perfomance", "project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.PerformanceStatus", "performence_PerformanceId", "dbo.Perfomance");
            DropForeignKey("dbo.Employee", "performance_PerformanceId", "dbo.Perfomance");
            DropForeignKey("dbo.Employee", "Atttendence_AtId", "dbo.Attendence");
            DropIndex("dbo.PerformanceStatus", new[] { "performence_PerformanceId" });
            DropIndex("dbo.Perfomance", new[] { "project_ProjectId" });
            DropIndex("dbo.Employee", new[] { "performance_PerformanceId" });
            DropIndex("dbo.Employee", new[] { "Atttendence_AtId" });
            DropTable("dbo.Projects");
            DropTable("dbo.PerformanceStatus");
            DropTable("dbo.Perfomance");
            DropTable("dbo.Employee");
            DropTable("dbo.Attendence");
        }
    }
}
