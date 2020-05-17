using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public static IEnumerable<ExamDetail> GetExamDetails(Func<ExamDetail, bool> predicate)
        {
            return GetExamDetails().Where(predicate);
        }

        public static TKey GetExamDetail<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            return GetExamDetails().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static TKey GetPropertyValue<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            return GetExamDetails().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static void AddOrUpdate(ExamDetail examDetail)
        {
            db.ExamDetails.AddOrUpdate(examDetail);
            db.SaveChanges();
        }

        public static void AddOrUpdate(IEnumerable<ExamDetail> examDetails)
        {
            db.ExamDetails.AddOrUpdate(examDetails.ToArray());
            db.SaveChanges();
        }

        public static void Delete(ExamDetail examDetail)
        {
            db.Entry(examDetail).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public static void Delete(IEnumerable<ExamDetail> examDetails)
        {
            examDetails.ToList().ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
            db.SaveChanges();
        }
    }
}
