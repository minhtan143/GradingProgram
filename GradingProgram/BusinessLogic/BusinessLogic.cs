using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    class BusinessLogic
    {
        protected static DatabaseContext db = new DatabaseContext();

        protected static IEnumerable<TKey> GetPropertyValue<T, TKey>(IEnumerable<T> item, Func<T, TKey> keySelector)
        {
            return item.Select(keySelector).Distinct();
        }
    }
}
