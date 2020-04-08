namespace GradingProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CandidateDetail",
                c => new
                    {
                        CandidateID = c.String(nullable: false, maxLength: 128),
                        ExamID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CandidateID, t.ExamID });
            
            CreateTable(
                "dbo.Candidate",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ExamDetail",
                c => new
                    {
                        ExamID = c.Int(nullable: false),
                        QuestionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExamID, t.QuestionID });
            
            CreateTable(
                "dbo.Exam",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CandidatesFolder = c.String(),
                        CreateDate = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Detail = c.String(storeType: "ntext"),
                        CreateDate = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Result",
                c => new
                    {
                        CandidateID = c.String(nullable: false, maxLength: 128),
                        ExamID = c.Int(nullable: false),
                        TestCaseID = c.Int(nullable: false),
                        Output = c.String(storeType: "ntext"),
                        RunTime = c.Int(),
                        UsedMemory = c.Int(),
                        Mark = c.Int(),
                        Notification = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => new { t.CandidateID, t.ExamID, t.TestCaseID });
            
            CreateTable(
                "dbo.TestCase",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Input = c.String(storeType: "ntext"),
                        Output = c.String(storeType: "ntext"),
                        TimeOut = c.Int(),
                        MemoryLimit = c.Int(),
                        Mark = c.Int(),
                        QuestionID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestCase");
            DropTable("dbo.Result");
            DropTable("dbo.Question");
            DropTable("dbo.Exam");
            DropTable("dbo.ExamDetail");
            DropTable("dbo.Candidate");
            DropTable("dbo.CandidateDetail");
        }
    }
}
