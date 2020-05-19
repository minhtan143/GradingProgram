using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLResult : BusinessLogic
    {
        public static List<Result> GetResults()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Results.ToList();
            }
        }

        public static List<TKey> GetResults<TKey>(Func<Result, bool> predicate, Func<Result, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Results.Where(predicate).Select(keySelector).ToList();
            }
        }

        public static List<Result> GetResults(Func<Result, bool> predicate)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Results.Where(predicate).ToList();
            }
        }

        public static int SumMark(int candidateId, int examId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                int? sum = db.Results.Where(x => x.CandidateID == candidateId && x.ExamID == examId).Sum(x => x.Mark);
                if (sum.HasValue)
                    return sum.Value;
                return 0;
            }
        }

        public static int SumMark(int candidateId, int examId, int questionId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                List<int> testCaseIds = BLTestCase.GetPropertyValues(x => x.QuestionID == questionId, y => y.ID);
                int? sum = db.Results.Where(x => x.CandidateID == candidateId && x.ExamID == examId && testCaseIds.Contains(x.TestCaseID)).Sum(x => x.Mark);
                if (sum.HasValue)
                    return sum.Value;
                return 0;
            }
        }

        public static void AddOrUpdate(Result result)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Results.AddOrUpdate(result);
                db.SaveChanges();
            }
        }

        public static void AddOrUpdate(List<Result> results)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Results.AddOrUpdate(results.ToArray());
                db.SaveChanges();
            }
        }

        public static void Delete(Result result)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(result).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public static void Delete(List<Result> results)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                results.ForEach(x => db.Entry(x).State = System.Data.Entity.EntityState.Deleted);
                db.SaveChanges();
            }
        }
    }
}
