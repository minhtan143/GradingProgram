using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingProgram
{
    public class BLExam : BusinessLogic
    {
        public static IEnumerable<Exam> GetExams()
        {
            return db.Exams.Where(x => x.Status == true);
        }

        public static Exam GetExam(int examId)
        {
            return GetExams().SingleOrDefault(x => x.ID == examId);
        }

        public static bool Exists(string examName)
        {
            return GetExams().Any(x => x.Name.ToLower() == examName.ToLower());
        }

        public static IEnumerable<TKey> GetExams<TKey>(Func<Exam, TKey> keySelector)
        {
            return GetPropertyValues(GetExams(), keySelector);
        }

        public static int SumMark(int examId)
        {
            return BLExamDetail.GetQuestions(examId).Sum(x => BLQuestion.SumMark(x.ID));
        }

        public static TKey GetPropertyValue<TKey>(Func<Exam, bool> predicate, Func<Exam, TKey> keySelector)
        {
            return GetExams().Where(predicate).Select(keySelector).SingleOrDefault();
        }

        public static void Add(Exam exam)
        {
            db.Exams.Add(exam);
            db.SaveChanges();
        }

        public static void Update(Exam exam)
        {
            db.Entry(exam).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(Exam exam)
        {
            exam.Status = false;
            db.SaveChanges();
        }
    }
}
