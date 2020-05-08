using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GradingProgram
{
    public class BusinessLogic
    {
        protected static DatabaseContext db = new DatabaseContext();

        protected static IEnumerable<TKey> GetPropertyValues<T, TKey>(IEnumerable<T> items, Func<T, TKey> keySelector)
        {
            return items.Select(keySelector).Distinct();
        }

        public static IEnumerable<T> Search<T>(IEnumerable<T> items, string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
                return items;
            List<string> searchStrings = searchString.Trim().ToLower().Split(' ').ToList();
            List<T> result = new List<T>();
            foreach (string str in searchStrings)
            {
                result.AddRange(items.Where(x =>
                {
                    foreach (var prop in x.GetType().GetProperties())
                        if (prop.GetValue(x).ToString().ToLower().Contains(str))
                            return true;
                    return false;
                }).ToList());
            }
            return result.Distinct();
        }

        public static object CloneObject(object objSource)
        {
            Type typeSource = objSource.GetType();
            object objTarget = Activator.CreateInstance(typeSource);

            PropertyInfo[] propertyInfo = typeSource.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (PropertyInfo property in propertyInfo)
                if (property.CanWrite)
                    property.SetValue(objTarget, property.GetValue(objSource, null), null);
            return objTarget;
        }

        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dt = new DataTable();

            PropertyDescriptorCollection propertys = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor property in propertys)
                dt.Columns.Add(property.Name);

            object[] values = new object[propertys.Count];
            foreach (T item in items)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertys[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }
    }
}
