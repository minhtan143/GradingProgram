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
        public static List<ExamDetail> GetExamDetails()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.ExamDetails.ToList();
            }
        }

        public static List<Question> GetQuestions(int examId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<Question> questions = new List<Question>();
                db.ExamDetails.Where(x => x.ExamID == examId).ToList().ForEach(x => questions.Add(BLQuestion.GetQuestion(x.QuestionID)));
                return questions;
            }
        }

        public static List<TKey> GetExamDetails<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.ExamDetails.Where(predicate).Select(keySelector).ToList();
            }
        }

        public static List<ExamDetail> GetExamDetails(Func<ExamDetail, bool> predicate)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.ExamDetails.Where(predicate).ToList();
            }
        }

        public static TKey GetExamDetail<TKey>(Func<ExamDetail, bool> predicate, Func<ExamDetail, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.ExamDetails.Where(predicate).Select(keySelector).SingleOrDefault();
            }
        }

        public static ExamDetail GetExamDetail(Func<ExamDetail, bool> predicate)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.ExamDetails.Where(predicate).SingleOrDefault();
            }
        }

        public static void AddOrUpdate(ExamDetail examDetail)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.ExamDetails.AddOrUpdate(examDetail);
                db.SaveChanges();
            }
        }

        public static void AddOrUpdate(List<ExamDetail> examDetails)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.ExamDetails.AddOrUpdate(examDetails.ToArray());
                db.SaveChanges();
            }
        }

        public static void Delete(ExamDetail examDetail)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(examDetail).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public static void Delete(List<ExamDetail> examDetails)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                examDetails.ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                db.SaveChanges();
            }
        }
    }
}
