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
        public static IEnumerable<Result> GetResults()
        {
            return db.Results;
        }

        public static IEnumerable<TKey> GetResults<TKey>(Func<Result, bool> predicate, Func<Result, TKey> keySelector)
        {
            return GetPropertyValues(GetResults().Where(predicate), keySelector);
        }

        public static int SumMark(int candidateId, int examId)
        {
            var sum = GetResults().Where(x => x.CandidateID == candidateId && x.ExamID == examId).Sum(x => x.Mark);
            if (sum.HasValue)
                return sum.Value;
            return 0;
        }

        public static int SumMark(int candidateId, int examId, int questionId)
        {
            var testCaseIds = BLQuestion.GetTestCases(questionId).ToList();
            var sum = GetResults().Where(x => x.CandidateID == candidateId && x.ExamID == examId && testCaseIds.Exists(y => y.ID == x.TestCaseID)).Sum(x => x.Mark);
            if (sum.HasValue)
                return sum.Value;
            return 0;
        }

        public static void AddOrUpdate(Result result)
        {
            db.Results.AddOrUpdate(result);
            db.SaveChanges();
        }

        public static void AddOrUpdate(IEnumerable<Result> results)
        {
            db.Results.AddOrUpdate(results.ToArray());
            db.SaveChanges();
        }

        public static void Delete(Result result)
        {
            db.Results.Remove(result);
            db.SaveChanges();
        }

        public static void Delete(IEnumerable<Result> results)
        {
            db.Results.RemoveRange(results);
            db.SaveChanges();
        }
    }
}
