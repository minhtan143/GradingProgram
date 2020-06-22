using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingProgram
{
    public class BLExam : BusinessLogic
    {
        public static List<Exam> GetExams()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Exams.Where(x => x.Status == true).ToList();
            }
        }

        public static Exam GetExam(int examId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Exams.Where(x => x.Status == true).SingleOrDefault(x => x.ID == examId);
            }
        }

        public static bool Exists(string examName)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Exams.Where(x => x.Status == true).Any(x => x.Name.ToLower() == examName.ToLower());
            }
        }

        public static List<TKey> GetExams<TKey>(Func<Exam, TKey> keySelector)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Exams.Where(x => x.Status == true).Select(keySelector).ToList();
            }
        }

        public static int SumMark(int examId)
        {
            return BLExamDetail.GetQuestions(examId).Sum(x => BLQuestion.SumMark(x.ID));
        }

        public static void Add(Exam exam)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Exams.Add(exam);
                db.SaveChanges();
            }
        }

        public static void Update(Exam exam)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(exam).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Delete(int examId)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                Exam exam = db.Exams.SingleOrDefault(x => x.Status == true && x.ID == examId);
                if (exam != null)
                {
                    exam.Status = false;
                    db.SaveChanges();
                }
            }
        }
    }
}
