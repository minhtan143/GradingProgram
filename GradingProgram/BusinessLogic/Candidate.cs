using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public partial class Candidate : BusinessLogic
    {
        public Candidate(string candidateId)
        {
            ID = candidateId;
        }

        public static IEnumerable<Candidate> GetCandidate()
        {
            return db.Candidates.Where(x => x.Status == true);
        }

        public static bool Update(Candidate candidate)
        {
            try
            {
                db.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(IEnumerable<Candidate> candidates)
        {
            try
            {
                db.Candidates.AddRange(candidates);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(Candidate candidate)
        {
            try
            {
                db.Candidates.Add(candidate);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Candidate candidate)
        {
            try
            {
                candidate.Status = false;
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
