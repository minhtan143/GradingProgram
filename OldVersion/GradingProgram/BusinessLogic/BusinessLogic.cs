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
        public static List<T> Search<T>(List<T> items, string searchString)
        {
            if (String.IsNullOrEmpty(searchString))
                return items;
            string[] searchStrings = searchString.Trim().ToLower().Split(' ');

            return items.Where(x =>
            {
                foreach (string str in searchStrings)
                    foreach (PropertyInfo prop in x.GetType().GetProperties())
                        if (prop.GetValue(x) != null && prop.GetValue(x).ToString().ToLower().Contains(str))
                            return true;
                return false;
            }).ToList();
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
