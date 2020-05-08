using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLQuestion : BusinessLogic
    {
        public static IEnumerable<Question> GetQuestions()
        {
            return db.Questions.Where(x => x.Status == true);
        }

        public static Question GetQuestion(int questionId)
        {
            return GetQuestions().SingleOrDefault(x => x.ID == questionId);
        }

        public static bool Exists(string questionName)
        {
            return GetQuestions().Count(x => x.Name == questionName) > 0;
        }

        public static IEnumerable<TKey> GetQuestions<TKey>(Func<Question, TKey> keySelector)
        {
            return GetQuestions().Select(keySelector);
        }

        public static IEnumerable<TestCase> GetTestCases(int questionId)
        {
            return BLTestCase.GetTestCases().Where(x => x.QuestionID == questionId);
        }

        public static TKey GetPropertyValue<TKey>(Func<Question, bool> predicate, Func<Question, TKey> keySelector)
        {
            return GetQuestions().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static int SumMark(int questionId)
        {
            return BLTestCase.SumMark(questionId);
        }

        public static void Add(Question question)
        {
            db.Questions.Add(question);
            db.SaveChanges();
        }

        public static void Update(Question question)
        {
            db.Entry(question).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(Question question)
        {
            question.Status = false;
            db.SaveChanges();
        }
    }
}
