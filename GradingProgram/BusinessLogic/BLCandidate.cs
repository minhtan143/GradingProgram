using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    class BLCandidate : BusinessLogic
    {
        public static IEnumerable<Candidate> GetCandidate()
        {
            return db.Candidates.Where(x => x.Status.HasValue);
        }
    }
}
