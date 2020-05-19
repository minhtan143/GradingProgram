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
        public static List<TestCase> GetTestCases()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.ToList();
            }
        }

        public static TestCase GetTestCase(int testcaseId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.SingleOrDefault(x => x.ID == testcaseId);
            }
        }

        public static List<TestCase> GetTestCases(int questionId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Where(x => x.QuestionID == questionId).ToList();
            }
        }

        public static bool Exists(int questionId, string testName)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Any(x => x.QuestionID == questionId && x.Name == testName);
            }
        }

        public static List<TKey> GetTestCases<TKey>(Func<TestCase, bool> predicate, Func<TestCase, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Where(predicate).Select(keySelector).ToList();
            }
        }

        public static List<TestCase> GetTestCases(Func<TestCase, bool> predicate)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Where(predicate).ToList();
            }
        }

        public static TKey GetPropertyValue<TKey>(Func<TestCase, bool> predicate, Func<TestCase, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Where(predicate).Select(keySelector).SingleOrDefault();
            }
        }

        public static List<TKey> GetPropertyValues<TKey>(Func<TestCase, bool> predicate, Func<TestCase, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Where(predicate).Select(keySelector).ToList();
            }
        }

        public static int SumMark(int questionId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.TestCases.Where(x => x.QuestionID == questionId).Sum(y => y.Mark).Value;
            }
        }

        public static void AddOrUpdate(TestCase testCase)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.TestCases.AddOrUpdate(testCase);
                db.SaveChanges();
            }
        }

        public static void AddOrUpdate(List<TestCase> testCases)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.TestCases.AddOrUpdate(testCases.ToArray());
                db.SaveChanges();
            }
        }

        public static void Delete(TestCase testCase)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(testCase).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public static void Delete(List<TestCase> testCases)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                testCases.ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                db.SaveChanges();
            }
        }
    }
}
