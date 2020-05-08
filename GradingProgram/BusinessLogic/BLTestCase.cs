using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLTestCase : BusinessLogic
    {
        public static IEnumerable<TestCase> GetTestCases()
        {
            return db.TestCases;
        }

        public static TestCase GetTestCase(int testcaseId)
        {
            return GetTestCases().SingleOrDefault(x => x.ID == testcaseId);
        }

        public static IEnumerable<TestCase> GetTestCases(int questionId)
        {
            return GetTestCases().Where(x => x.QuestionID == questionId);
        }

        public static bool Exists(int questionId, string testName)
        {
            return GetTestCases().Count(x => x.QuestionID == questionId && x.Name == testName) > 0;
        }

        public static IEnumerable<TKey> GetTestCases<TKey>(Func<TestCase, bool> predicate, Func<TestCase, TKey> keySelector)
        {
            return GetTestCases().Where(predicate).Select(keySelector);
        }

        public static TKey GetPropertyValue<TKey>(Func<TestCase, bool> predicate, Func<TestCase, TKey> keySelector)
        {
            return GetTestCases().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static int SumMark(int questionId)
        {
            return GetTestCases().Where(x => x.QuestionID == questionId).Sum(y => y.Mark).Value;
        }

        public static void AddOrUpdate(TestCase testCase)
        {
            db.TestCases.AddOrUpdate(testCase);
            db.SaveChanges();
        }

        public static void AddOrUpdate(IEnumerable<TestCase> testCases)
        {
            db.TestCases.AddOrUpdate(testCases.ToArray());
            db.SaveChanges();
        }

        public static void Delete(TestCase testCase)
        {
            db.TestCases.Remove(testCase);
            db.SaveChanges();
        }

        public static void Delete(IEnumerable<TestCase> testCases)
        {
            db.TestCases.RemoveRange(testCases);
            db.SaveChanges();
        }
    }
}
