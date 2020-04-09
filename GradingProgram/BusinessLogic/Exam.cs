using System.Collections.Generic;
using System.Linq;

namespace GradingProgram
{
    public partial class Exam : BusinessLogic
    {
        public Exam(int examId)
        {
            ID = examId;
        }

        public static IEnumerable<Exam> GetExam()
        {
            return db.Exams.Where(x => x.Status == true);
        }

        public static bool Add(Exam exam)
        {
            try
            {
                db.Exams.Add(exam);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Exam exam)
        {
            try
            {
                db.Entry(exam).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Exam exam)
        {
            try
            {
                exam.Status = false;
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
