using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GradingProject
{
    [Table("Candidate")]
    public partial class Candidate
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool? Status { get; set; }
    }

    [Table("CandidateDetail")]
    public partial class CandidateDetail
    {
        [Key]
        [Column(Order = 0)]
        public string CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ExamID { get; set; }
    }

    [Table("Exam")]
    public partial class Exam
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string CandidatesFolder { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }
    }

    [Table("ExamDetail")]
    public partial class ExamDetail
    {
        [Key]
        [Column(Order = 0)]
        public int ExamID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int QuestionID { get; set; }
    }

    [Table("Question")]
    public partial class Question
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }
    }

    [Table("Result")]
    public partial class Result
    {
        [Key]
        [Column(Order = 0)]
        public string CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ExamID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int TestCaseID { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        public int? Mark { get; set; }

        [Column(TypeName = "ntext")]
        public string Notification { get; set; }
    }

    [Table("TestCase")]
    public partial class TestCase
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Input { get; set; }

        [Column(TypeName = "ntext")]
        public string Output { get; set; }

        public int? TimeOut { get; set; }

        public int? MemoryLimit { get; set; }

        public int? Mark { get; set; }

        public int? QuestionID { get; set; }
    }

    public partial class GradingProgramDbContext : DbContext
    {
        public GradingProgramDbContext() : base("name=Database") { }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateDetail> CandidateDetails { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<TestCase> TestCases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<CandidateDetail>()
                .Property(e => e.CandidateID)
                .IsFixedLength();

            modelBuilder.Entity<Result>()
                .Property(e => e.CandidateID)
                .IsFixedLength();

            modelBuilder.Entity<TestCase>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
