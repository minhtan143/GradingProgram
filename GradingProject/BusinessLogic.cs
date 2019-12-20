using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProject
{
    class BusinessLogic
    {
        protected static GradingProgramDbContext db = new GradingProgramDbContext();

        protected static DataTable ToDataTable<T>(IEnumerable<T> item)
        {
            var properties = typeof(T).GetProperties();
            var table = new DataTable();

            foreach (var property in properties)
            {
                table.Columns.Add(property.Name, property.PropertyType);
            }

            table.Rows.Add(properties.Select(p => p.GetValue(item, null)).ToArray());
            return table;
        }
    }

    class BLCandidate : BusinessLogic
    {
        public static DataTable GetCandidate()
        {
            return ToDataTable(db.Candidates.Where(x => x.Status == true));
        }
    }

    class BLCandidateDetail : BusinessLogic
    {

    }

    class BLExam : BusinessLogic
    {

    }

    class BLExamDetail : BusinessLogic
    {

    }

    class BLQuestion : BusinessLogic
    {

    }

    class BLResult : BusinessLogic
    {

    }

    class BLTestcase : BusinessLogic
    {

    }
}
