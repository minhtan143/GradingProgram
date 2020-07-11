namespace GradingProgram.Data.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? QuestionId { get; set; }
        public int? TestcaseId { get; set; }
        public string Output { get; set; }
        public int? RunTime { get; set; }
        public long? UsedMemory { get; set; }
        public int? Mark { get; set; }
        public string Notification { get; set; }

        public Candidate Candidate { get; set; }
        public Question Question { get; set; }
        public Testcase Testcase { get; set; }
    }
}
