namespace GradingProgram.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 100),
                        Name = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        ExamId = c.Int(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exam", t => t.ExamId)
                .Index(t => t.ExamId);
            
            CreateTable(
                "dbo.Exam",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Folder = c.String(maxLength: 500),
                        CreateDate = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExamQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamId = c.Int(),
                        QuestionId = c.Int(),
                        FileName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exam", t => t.ExamId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.ExamId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        File = c.String(maxLength: 500),
                        Detail = c.String(storeType: "ntext"),
                        CreateDate = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Result",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(),
                        QuestionId = c.Int(),
                        TestcaseId = c.Int(),
                        Output = c.String(storeType: "ntext"),
                        RunTime = c.Int(),
                        UsedMemory = c.Long(),
                        Mark = c.Int(),
                        Notification = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.CandidateId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .ForeignKey("dbo.Testcase", t => t.TestcaseId)
                .Index(t => t.CandidateId)
                .Index(t => t.QuestionId)
                .Index(t => t.TestcaseId);
            
            CreateTable(
                "dbo.Testcase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Input = c.String(storeType: "ntext"),
                        Output = c.String(storeType: "ntext"),
                        TimeLimit = c.Int(),
                        MemoryLimit = c.Int(),
                        Mark = c.Int(),
                        QuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamQuestion", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Result", "TestcaseId", "dbo.Testcase");
            DropForeignKey("dbo.Testcase", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Result", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Result", "CandidateId", "dbo.Candidate");
            DropForeignKey("dbo.ExamQuestion", "ExamId", "dbo.Exam");
            DropForeignKey("dbo.Candidate", "ExamId", "dbo.Exam");
            DropIndex("dbo.Testcase", new[] { "QuestionId" });
            DropIndex("dbo.Result", new[] { "TestcaseId" });
            DropIndex("dbo.Result", new[] { "QuestionId" });
            DropIndex("dbo.Result", new[] { "CandidateId" });
            DropIndex("dbo.ExamQuestion", new[] { "QuestionId" });
            DropIndex("dbo.ExamQuestion", new[] { "ExamId" });
            DropIndex("dbo.Candidate", new[] { "ExamId" });
            DropTable("dbo.Testcase");
            DropTable("dbo.Result");
            DropTable("dbo.Question");
            DropTable("dbo.ExamQuestion");
            DropTable("dbo.Exam");
            DropTable("dbo.Candidate");
        }
    }
}
