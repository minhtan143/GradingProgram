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
        public static List<Candidate> GetCandidates()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Candidates.Where(x => x.Status == true).ToList();
            }
        }

        public static bool Exists(string candidateCode)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Candidates.Where(x => x.Status == true).Any(x => x.Code.ToLower() == candidateCode.ToLower());
            }
        }

        public static Candidate GetCandidate(int candidateId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Candidates.Where(x => x.Status == true).SingleOrDefault(x => x.ID == candidateId);
            }
        }

        public static Candidate GetCandidate(string candidateCode)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Candidates.Where(x => x.Status == true).SingleOrDefault(x => x.Code == candidateCode);
            }
        }

        public static DataTable GetCandidateWithMark(int examId)
        {
            DataTable res = new DataTable();
            res.Columns.Add("ID");
            res.Columns.Add("Code");
            res.Columns.Add("Name");

            List<Question> questions = BLExamDetail.GetQuestions(examId);
            for (int i = 0; i < questions.Count(); i++)
                res.Columns.Add(BLExamDetail.GetExamDetail(x => x.ExamID == examId && x.QuestionID == questions[i].ID, y => y.FileName), typeof(int));
            res.Columns.Add("Tổng điểm", typeof(int));

            List<Candidate> candidates = BLCandidateDetail.GetCandidates(examId);
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
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Add(IEnumerable<Candidate> candidates)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Candidates.AddRange(candidates);
                db.SaveChanges();
            }
        }

        public static void Add(Candidate candidate)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Candidates.Add(candidate);
                db.SaveChanges();
            }
        }

        public static void Delete(int candidateId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Candidate candidate = db.Candidates.SingleOrDefault(x => x.Status == true && x.ID == candidateId);
                if (candidate != null)
                {
                    candidate.Status = false;
                    db.SaveChanges();
                }
            }
        }
    }
}
