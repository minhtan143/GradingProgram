using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BLCandidate : BusinessLogic
    {
        public static IEnumerable<Candidate> GetCandidates()
        {
            return db.Candidates.Where(x => x.Status == true);
        }

        public static bool Exists(string candidateCode)
        {
            return GetCandidates().Any(x => x.Code == candidateCode);
        }

        public static Candidate GetCandidate(int candidateId)
        {
            return GetCandidates().SingleOrDefault(x => x.ID == candidateId);
        }

        public static Candidate GetCandidate(string candidateCode)
        {
            return GetCandidates().SingleOrDefault(x => x.Code == candidateCode);
        }

        public static IEnumerable<TKey> GetCandidates<TKey>(Func<Candidate, TKey> keySelector)
        {
            return GetPropertyValues(GetCandidates(), keySelector);
        }

        public static TKey GetPropertyValue<TKey>(Func<Candidate, bool> predicate, Func<Candidate, TKey> keySelector)
        {
            return GetCandidates().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static DataTable GetCandidateWithMark(int examId)
        {
            DataTable res = new DataTable();
            res.Columns.Add("ID");
            res.Columns.Add("Code");
            res.Columns.Add("Name");

            var questions = BLExamDetail.GetQuestions(examId).ToList();
            for (int i = 0; i < questions.Count(); i++)
                res.Columns.Add(BLExamDetail.GetExamDetail(x => x.ExamID == examId && x.QuestionID == questions[i].ID, y => y.FileName), typeof(int));
            res.Columns.Add("Tổng điểm", typeof(int));

            var candidates = BLCandidateDetail.GetCandidates(examId).ToList();
            for (int i = 0; i < candidates.Count(); i++)
            {
                List<string> vs = new List<string>();
                vs.Add(candidates[i].ID.ToString());
                vs.Add(candidates[i].Code);
                vs.Add(candidates[i].Name);
                for (int j = 0; j < questions.Count(); j++)
                    vs.Add(BLResult.SumMark(candidates[i].ID, examId, questions[j].ID).ToString());
                vs.Add(BLResult.SumMark(candidates[i].ID, examId).ToString());
                res.Rows.Add(vs.ToArray());
            }
            return res;
        }

        public static void Update(Candidate candidate)
        {
            db.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Add(IEnumerable<Candidate> candidates)
        {
            db.Candidates.AddRange(candidates);
            db.SaveChanges();
        }

        public static void Add(Candidate candidate)
        {
            db.Candidates.Add(candidate);
            db.SaveChanges();
        }

        public static void Delete(Candidate candidate)
        {
            candidate.Status = false;
            db.SaveChanges();
        }
    }
}
