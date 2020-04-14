using System;
using System.Collections.Generic;
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

        public static bool Update(TestCase testCase)
        {
            try
            {
                db.Entry(testCase).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(IEnumerable<TestCase> testCases)
        {
            try
            {
                db.Entry(testCases).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(TestCase testCase)
        {
            try
            {
                db.TestCases.Add(testCase);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(IEnumerable<TestCase> testCases)
        {
            try
            {
                db.TestCases.AddRange(testCases);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(TestCase testCase)
        {
            try
            {
                db.TestCases.Remove(testCase);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(IEnumerable<TestCase> testCases)
        {
            try
            {
                db.TestCases.RemoveRange(testCases);
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
