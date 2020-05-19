using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLCandidateDetail : BusinessLogic
    {
        public static List<CandidateDetail> GetCandidateDetails()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.CandidateDetails.ToList();
            }
        }

        public static List<Exam> GetExams(int candidateId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<Exam> exams = new List<Exam>();
                db.CandidateDetails.Where(x => x.CandidateID == candidateId).ToList().ForEach(x => exams.Add(BLExam.GetExam(x.ExamID)));
                return exams;
            }
        }

        public static List<Candidate> GetCandidates(int examId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<Candidate> candidates = new List<Candidate>();
                db.CandidateDetails.Where(x => x.ExamID == examId).ToList().ForEach(x => candidates.Add(BLCandidate.GetCandidate(x.CandidateID)));
                return candidates;
            }
        }

        public static List<CandidateDetail> GetCandidateDetails(Func<CandidateDetail, bool> predicate)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.CandidateDetails.Where(predicate).ToList();
            }
        }

        public static void Add(CandidateDetail candidateDetail)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.CandidateDetails.Add(candidateDetail);
                db.SaveChanges();
            }
        }

        public static void Add(List<CandidateDetail> candidateDetails)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.CandidateDetails.AddRange(candidateDetails);
                db.SaveChanges();
            }
        }

        public static void Delete(CandidateDetail candidateDetail)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(candidateDetail).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public static void Delete(List<CandidateDetail> candidateDetails)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                candidateDetails.ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                db.SaveChanges();
            }
        }
    }
}
