using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public partial class Question : BusinessLogic
    {
        public Question(int questionId)
        {
            ID = questionId;
        }

        public static IEnumerable<Question> GetQuestion()
        {
            return db.Questions.Where(x => x.Status == true);
        }

        public static IEnumerable<TestCase> GetTestCases(int questionId)
        {
            //lamda code
            return TestCase.GetTestCases();
        }

        public static bool Add(Question question)
        {
            try
            {
                db.Questions.Add(question);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Question question)
        {
            try
            {
                question.Status = false;
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
