using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLExamDetail : BusinessLogic
    {
        public static IEnumerable<ExamDetail> GetExamDetails()
        {
            return db.ExamDetails;
        }

        public static IEnumerable<Question> GetQuestions(int examId)
        {
            return GetExamDetails().Where(x => x.ExamID == examId).OrderBy(x => x.FileName).Select(x => BLQuestion.GetQuestion(x.QuestionID));
        }

        public static IEnumerable<TKey> GetExamDetails<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            return GetExamDetails().Where(predicate).Select(keySelector);
        }

        public static TKey GetExamDetail<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            return GetExamDetails().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static TKey GetPropertyValue<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            return GetExamDetails().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static void Add(ExamDetail examDetail)
        {
            db.ExamDetails.Add(examDetail);
            db.SaveChanges();
        }

        public static void Add(IEnumerable<ExamDetail> examDetails)
        {
            db.ExamDetails.AddRange(examDetails);
            db.SaveChanges();
        }

        public static void Delete(ExamDetail examDetail)
        {
            db.Entry(examDetail).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
