using System.Data.Entity;

namespace GradingProgram
{
    class DatabaseContext : DbContext
    {
        public static string connectionString = "data source=(local);initial catalog=GradingProgram;integrated security=True;MultipleActiveResultSets=True";
        
        public DatabaseContext() : base(connectionString) { }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateDetail> CandidateDetails { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<TestCase> TestCases { get; set; }
    }
}
