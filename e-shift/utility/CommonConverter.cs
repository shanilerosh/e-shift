using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.utility
{
    /*Common class to make generic conversions*/
    internal class CommonConverter<T>
    {
        public static IDictionary<string, string> convertObjectToDirectory(T obj) {
            try
            {

                PropertyInfo[] propertyInfos = obj.GetType().GetProperties();

                var dictionary = new Dictionary<string, string>();

                foreach (var propery in propertyInfos)
                {
                    string key = "@" + (propery.Name.ToString().ToLower());
                    string? value = propery.GetValue(obj).ToString();

                    dictionary.Add(key, value);
                }

                return dictionary;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
