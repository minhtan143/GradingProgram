using GradingProgram.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GradingProgram.Data.Services
{
    public class BLCandidate
    {
        public async Task<List<Candidate>> GetCandidateOfExamAsync(int examId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var res = await db.Candidates.Where(x => x.ExamId == examId).ToListAsync();
                return res;
            }
        }
    }
}
