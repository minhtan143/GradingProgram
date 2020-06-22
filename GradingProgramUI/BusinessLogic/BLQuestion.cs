using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLQuestion : BusinessLogic
    {
        public static List<Question> GetQuestions()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).ToList();
            }
        }

        public static Question GetQuestion(int questionId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).SingleOrDefault(x => x.ID == questionId);
            }
        }

        public static bool Exists(string questionName)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).Any(x => x.Name.ToLower() == questionName.ToLower());
            }
        }

        public static List<TKey> GetQuestions<TKey>(Func<Question, bool> predicate, Func<Question, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).Where(predicate).Select(keySelector).ToList();
            }
        }

        public static List<TKey> GetQuestions<TKey>(Func<Question, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).Select(keySelector).ToList();
            }
        }

        public static List<TestCase> GetTestCases(int questionId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return BLTestCase.GetTestCases(x => x.QuestionID == questionId);
            }
        }

        public static TKey GetPropertyValue<TKey>(Func<Question, bool> predicate, Func<Question, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).Where(predicate).Select(keySelector).SingleOrDefault();
            }
        }

        public static List<TKey> GetPropertyValues<TKey>(Func<Question, bool> predicate, Func<Question, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Questions.Where(x => x.Status == true).Where(predicate).Select(keySelector).ToList();
            }
        }

        public static int SumMark(int questionId)
        {
            return BLTestCase.SumMark(questionId);
        }

        public static void Add(Question question)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Questions.Add(question);
                db.SaveChanges();
            }
        }

        public static void Update(Question question)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(question).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Delete(int questionId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Question question = db.Questions.SingleOrDefault(x => x.Status == true && x.ID == questionId);
                if (question != null)
                {
                    question.Status = false;
                    db.SaveChanges();
                }
            }
        }
    }
}
