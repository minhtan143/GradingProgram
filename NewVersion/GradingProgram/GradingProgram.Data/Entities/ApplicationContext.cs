using System.Data.Entity;

namespace GradingProgram.Data.Entities
{
    public class ApplicationContext : DbContext
    {
        private const string connection = "data source=.;initial catalog=GradingProgram;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public ApplicationContext() : base(connection) { }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Testcase> Testcases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Candidate
            modelBuilder.Entity<Candidate>()
                .ToTable("Candidate");

            modelBuilder.Entity<Candidate>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Code)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Candidate>()
                .Property(e => e.Status);
            #endregion

            #region Exam
            modelBuilder.Entity<Exam>()
                .ToTable("Exam");

            modelBuilder.Entity<Exam>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Exam>()
                .Property(e => e.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Exam>()
                .Property(e => e.Folder)
                .HasColumnType("nvarchar")
                .HasMaxLength(500);

            modelBuilder.Entity<Exam>()
                .Property(e => e.CreateDate);

            modelBuilder.Entity<Exam>()
                .Property(e => e.Status);
            #endregion

            #region ExamQuestion
            modelBuilder.Entity<ExamQuestion>()
                .ToTable("ExamQuestion");

            modelBuilder.Entity<ExamQuestion>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ExamQuestion>()
                .Property(e => e.FileName)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<ExamQuestion>()
                .HasOptional(e => e.Exam)
                .WithMany(e => e.ExamQuestions)
                .HasForeignKey(e => e.ExamId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExamQuestion>()
                .HasOptional(e => e.Question)
                .WithMany(e => e.ExamQuestions)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);
            #endregion

            #region Question
            modelBuilder.Entity<Question>()
                .ToTable("Question");

            modelBuilder.Entity<Question>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Question>()
                .Property(e => e.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Question>()
                .Property(e => e.File)
                .HasColumnType("nvarchar")
                .HasMaxLength(500);

            modelBuilder.Entity<Question>()
                .Property(e => e.Detail)
                .HasColumnType("ntext");

            modelBuilder.Entity<Question>()
                .Property(e => e.CreateDate);

            modelBuilder.Entity<Question>()
                .Property(e => e.Status);
            #endregion

            #region Result
            modelBuilder.Entity<Result>()
                .ToTable("Result");

            modelBuilder.Entity<Result>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Result>()
                .Property(e => e.Output)
                .HasColumnType("ntext");

            modelBuilder.Entity<Result>()
                .Property(e => e.RunTime);

            modelBuilder.Entity<Result>()
                .Property(e => e.UsedMemory);

            modelBuilder.Entity<Result>()
                .Property(e => e.Mark);

            modelBuilder.Entity<Result>()
                .Property(e => e.Notification);

            modelBuilder.Entity<Result>()
                .HasOptional(e => e.Candidate)
                .WithMany(e => e.Results)
                .HasForeignKey(e => e.CandidateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Result>()
                .HasOptional(e => e.Question)
                .WithMany(e => e.Results)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Result>()
                .HasOptional(e => e.Testcase)
                .WithMany(e => e.Results)
                .HasForeignKey(e => e.TestcaseId)
                .WillCascadeOnDelete(false);
            #endregion

            #region Testcase
            modelBuilder.Entity<Testcase>()
                .ToTable("Testcase");

            modelBuilder.Entity<Testcase>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Testcase>()
                .Property(e => e.Input)
                .HasColumnType("ntext");

            modelBuilder.Entity<Testcase>()
                .Property(e => e.Output)
                .HasColumnType("ntext");

            modelBuilder.Entity<Testcase>()
                .Property(e => e.TimeLimit);

            modelBuilder.Entity<Testcase>()
                .Property(e => e.MemoryLimit);

            modelBuilder.Entity<Testcase>()
                .Property(e => e.Mark);

            modelBuilder.Entity<Testcase>()
                .HasOptional(e => e.Question)
                .WithMany(e => e.Testcases)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);
            #endregion
        }
    }
}
