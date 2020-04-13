using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public partial class ExamDetail : BusinessLogic
    {
        public ExamDetail(int examId, int questionId)
        {
            ExamID = examId;
            QuestionID = questionId;
        }

        public static IEnumerable<CandidateDetail> GetExamDetail()
        {
            return db.CandidateDetails;
        }

        public static bool Add(ExamDetail examDetail)
        {
            try
            {
                db.ExamDetails.Add(examDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(IEnumerable<ExamDetail> examDetails)
        {
            try
            {
                db.ExamDetails.AddRange(examDetails);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(ExamDetail examDetail)
        {
            try
            {
                db.Entry(examDetail).State = System.Data.Entity.EntityState.Deleted;
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
