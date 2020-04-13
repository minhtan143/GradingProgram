using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public partial class Result : BusinessLogic
    {
        public static IEnumerable<Result> GetResult()
        {
            return db.Results;
        }

        public static int SumOf(string candidateId, int examId)
        {
            var sum = GetResult().Where(x => x.CandidateID == candidateId && x.ExamID == examId).Sum(x => x.Mark);
            if (sum.HasValue)
                return sum.Value;
            return 0;
        }

        public static int SumOf(string candidateId, int examId, int questionId)
        {
            var testCases = Question.GetTestCases(questionId);
            var sum = GetResult().Where(x => x.CandidateID == candidateId && x.ExamID == examId/*error*/).Sum(x => x.Mark);
            if (sum.HasValue)
                return sum.Value;
            return 0;
        }

        public static bool Add(Result result)
        {
            try
            {
                db.Results.Add(result);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(IEnumerable<Result> results)
        {
            try
            {
                db.Results.AddRange(results);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Result result)
        {
            try
            {
                db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(IEnumerable<Result> results)
        {
            try
            {
                db.Entry(results).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Result result)
        {
            try
            {
                db.Results.Remove(result);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(IEnumerable<Result> results)
        {
            try
            {
                db.Results.RemoveRange(results);
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
