using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProject
{
    class BusinessLogic
    {
        protected static GradingProgramDbContext db = new GradingProgramDbContext();

        public static DataTable ToDataTable<T>(T item) where T : class
        {
            var properties = typeof(T).GetProperties();
            DataTable table = new DataTable();

            foreach (var property in properties)
                table.Columns.Add(property.Name, property.PropertyType);

            table.Rows.Add(properties.Select(p => p.GetValue(item, null)).ToArray());
            return table;
        }

        protected static IEnumerable<TKey> GetPropertyValue<T, TKey>(IEnumerable<T> item, Func<T, TKey> keySelector)
        {
            return item.Select(keySelector).Distinct();
        }
    }

    class BLCandidate : BusinessLogic
    {
        public static IEnumerable<Candidate> GetCandidate()
        {
            return db.Candidates.Where(x => x.Status == true);
        }

        public static IEnumerable<Candidate> GetCandidate(int examId)
        {
            var candidatesId = BLCandidateDetail.GetCandidatesOf(examId);
            return GetCandidate().Where(x => candidatesId.Contains(x.ID));
        }

        public static Candidate GetCandidateByID(string candidateId)
        {
            return GetCandidate().SingleOrDefault(x => x.ID == candidateId);
        }

        public static TKey GetPropertyValue<TKey>(string candidateId, Func<Candidate, TKey> keySelector)
        {
            return keySelector(GetCandidateByID(candidateId));
        }

        public static IEnumerable<TKey> GetPropertyValue<TKey>(Func<Candidate, TKey> keySelector)
        {
            return GetPropertyValue(GetCandidate(), keySelector);
        }

        public static bool AddOrUpdate(Candidate candidate)
        {
            try
            {
                candidate.Status = true;
                db.Candidates.AddOrUpdate(x => x.ID, candidate);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(string candidateId)
        {
            try
            {
                Candidate candidate = new Candidate();
                candidate.ID = candidateId;
                candidate.Status = true;
                db.Candidates.Add(candidate);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(string candidateId)
        {
            try
            {
                var oldCandidate = GetCandidateByID(candidateId);
                if (oldCandidate == null)
                    return false;
                oldCandidate.Status = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class BLCandidateDetail : BusinessLogic
    {
        public static IEnumerable<CandidateDetail> GetCandidateDetail()
        {
            return db.CandidateDetails;
        }

        public static CandidateDetail GetCandidateDetailByID(string candidateId, int examId)
        {
            return GetCandidateDetail().SingleOrDefault(x => x.CandidateID == candidateId && x.ExamID == examId);
        }

        public static IEnumerable<string> GetCandidatesOf(int examId)
        {
            return GetCandidateDetail().Where(x => x.ExamID == examId).Select(x => x.CandidateID);
        }

        public static IEnumerable<int> GetExamOf(string candidateId)
        {
            return GetCandidateDetail().Where(x => x.CandidateID == candidateId).Select(x => x.ExamID);
        }

        public static bool Add(string candidateId, int examId)
        {
            try
            {
                CandidateDetail candidateDetail = new CandidateDetail();
                candidateDetail.CandidateID = candidateId;
                candidateDetail.ExamID = examId;
                db.CandidateDetails.Add(candidateDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(string candidateId, int examId)
        {
            try
            {
                var oldCandidateDetail = GetCandidateDetailByID(candidateId, examId);
                if (oldCandidateDetail == null)
                    return false;
                db.CandidateDetails.Remove(oldCandidateDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class BLExam : BusinessLogic
    {
        public static IEnumerable<Exam> GetExam()
        {
            return db.Exams.Where(x => x.Status == true);
        }

        public static Exam GetExamByID(int examId)
        {
            return GetExam().SingleOrDefault(x => x.ID == examId);
        }

        public static TKey GetPropertyValue<TKey>(int examId, Func<Exam, TKey> keySelector)
        {
            return keySelector(GetExamByID(examId));
        }

        public static IEnumerable<TKey> GetPropertyValue<TKey>(Func<Exam, TKey> keySelector)
        {
            return GetPropertyValue(GetExam(), keySelector);
        }

        public static bool AddOrUpdate(Exam exam)
        {
            try
            {
                exam.CreateDate = DateTime.Now;
                exam.Status = true;
                db.Exams.AddOrUpdate(x => x.ID, exam);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(int examId)
        {
            try
            {
                var oldExam = GetExamByID(examId);
                if (oldExam == null)
                    return false;
                oldExam.Status = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class BLExamDetail : BusinessLogic
    {
        public static IEnumerable<ExamDetail> GetExamDetail()
        {
            return db.ExamDetails;
        }

        public static ExamDetail GetExamDetailByID(int examId, int questionId)
        {
            return GetExamDetail().SingleOrDefault(x => x.ExamID == examId && x.QuestionID == questionId);
        }

        public static IEnumerable<int> GetQuestionOf(int examId)
        {
            return GetExamDetail().Where(x => x.ExamID == examId).Select(x => x.QuestionID);
        }

        public static IEnumerable<int> GetExamOf(int questionId)
        {
            return GetExamDetail().Where(x => x.QuestionID == questionId).Select(x => x.ExamID);
        }

        public static bool Add(int examId, int questionId)
        {
            try
            {
                ExamDetail examDetail = new ExamDetail();
                examDetail.ExamID = examId;
                examDetail.QuestionID = questionId;
                db.ExamDetails.Add(examDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(int examId, int questionId)
        {
            try
            {
                var oldExamDetail = GetExamDetailByID(examId, questionId);
                if (oldExamDetail == null)
                    return false;
                db.ExamDetails.Remove(oldExamDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class BLQuestion : BusinessLogic
    {
        public static IEnumerable<Question> GetQuestion()
        {
            return db.Questions.Where(x => x.Status == true);
        }

        public static Question GetQuestionByID(int questionId)
        {
            return GetQuestion().SingleOrDefault(x => x.ID == questionId);
        }

        public static TKey GetPropertyValue<TKey>(int questionId, Func<Question, TKey> keySelector)
        {
            return keySelector(GetQuestionByID(questionId));
        }

        public static IEnumerable<TKey> GetPropertyValue<TKey>(Func<Question, TKey> keySelector)
        {
            return GetPropertyValue(GetQuestion(), keySelector);
        }

        public static bool AddOrUpdate(Question question)
        {
            try
            { 
                question.CreateDate = DateTime.Now;
                question.Status = true;
                db.Questions.AddOrUpdate(x => x.ID, question);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(int questionId)
        {
            try
            {
                var oldQuestion = GetQuestionByID(questionId);
                if (oldQuestion == null)
                    return false;
                oldQuestion.Status = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class BLResult : BusinessLogic
    {
        public static IEnumerable<Result> GetResult()
        {
            return db.Results;
        }

        public static Result GetResultByID(string candidateId, int examId, int testCaseId)
        {
            return GetResult().SingleOrDefault(x => x.CandidateID == candidateId && x.ExamID == examId && x.TestCaseID == testCaseId);
        }

        public static TKey GetPropertyValue<TKey>(string candidateId, int examId, int testCaseId, Func<Result, TKey> keySelector)
        {
            return keySelector(GetResultByID(candidateId, examId, testCaseId));
        }

        public static IEnumerable<TKey> GetPropertyValue<TKey>(Func<Result, TKey> keySelector)
        {
            return GetPropertyValue(GetResult(), keySelector);
        }

        public static bool AddOrUpdate(Result result)
        {
            try
            {
                db.Results.AddOrUpdate(x => new { x.CandidateID, x.ExamID, x.TestCaseID }, result);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(string candidateId, int examId, int testCaseId)
        {
            try
            {
                var oldResult = GetResultByID(candidateId, examId, testCaseId);
                if (oldResult == null)
                    return false;
                db.Results.Remove(oldResult);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class BLTestcase : BusinessLogic
    {
        public static IEnumerable<TestCase> GetTestcase()
        {
            return db.TestCases;
        }

        public static TestCase GetTestcaseByID(int testCaseId)
        {
            return GetTestcase().SingleOrDefault(x => x.ID == testCaseId);
        }

        public static TKey GetPropertyValue<TKey>(int testCaseId, Func<TestCase, TKey> keySelector)
        {
            return keySelector(GetTestcaseByID(testCaseId));
        }

        public static IEnumerable<TKey> GetPropertyValue<TKey>(Func<TestCase, TKey> keySelector)
        {
            return GetPropertyValue(GetTestcase(), keySelector);
        }

        public static bool AddOrUpdate(TestCase testCase)
        {
            try
            {
                db.TestCases.AddOrUpdate(x => x.ID, testCase);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(int testCaseId)
        {
            try
            {
                var oldTestCase = GetTestcaseByID(testCaseId);
                if (oldTestCase == null)
                    return false;
                db.TestCases.Remove(oldTestCase);
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
