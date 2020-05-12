using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLCandidateDetail : BusinessLogic
    {
        public static IEnumerable<CandidateDetail> GetCandidateDetails()
        {
            return db.CandidateDetails;
        }

        public static IEnumerable<Exam> GetExams(int candidateId)
        {
            return GetCandidateDetails().Where(x => x.CandidateID == candidateId).Select(x => BLExam.GetExam(x.ExamID));
        }

        public static IEnumerable<Candidate> GetCandidates(int examId)
        {
            return GetCandidateDetails().Where(x => x.ExamID == examId).Select(x => BLCandidate.GetCandidate(x.CandidateID));
        }

        public static IEnumerable<TKey> GetCandidateDetails<TKey>(Func<CandidateDetail, bool> predicate, Func<CandidateDetail, TKey> keySelector)
        {
            return GetCandidateDetails().Where(predicate).Select(keySelector);
        }

        public static void Add(CandidateDetail candidateDetail)
        {
            db.CandidateDetails.Add(candidateDetail);
            db.SaveChanges();
        }

        public static void Add(IEnumerable<CandidateDetail> candidateDetails)
        {
            db.CandidateDetails.AddRange(candidateDetails);
            db.SaveChanges();
        }

        public static void Delete(CandidateDetail candidateDetail)
        {
            db.Entry(candidateDetail).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
