using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public partial class CandidateDetail : BusinessLogic
    {
        public CandidateDetail(string candidateId, int examId)
        {
            CandidateID = candidateId;
            ExamID = examId;
        }

        public static IEnumerable<CandidateDetail> GetCandidateDetail()
        {
            return db.CandidateDetails;
        }

        public static bool Add(CandidateDetail candidateDetail)
        {
            try
            {
                db.CandidateDetails.Add(candidateDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(IEnumerable<CandidateDetail> candidateDetails)
        {
            try
            {
                db.CandidateDetails.AddRange(candidateDetails);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(CandidateDetail candidateDetail)
        {
            try
            {
                db.Entry(candidateDetail).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
