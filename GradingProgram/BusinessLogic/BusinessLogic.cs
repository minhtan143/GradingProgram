using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BusinessLogic
    {
        protected static DatabaseContext db = new DatabaseContext();

        protected static IEnumerable<TKey> GetPropertyValue<T, TKey>(IEnumerable<T> items, Func<T, TKey> keySelector)
        {
            return items.Select(keySelector).Distinct();
        }

        protected static IEnumerable<T> GetByProperty<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            return items.Where(predicate);
        }
    }
}
