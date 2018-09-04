using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JiaMiXu.Core
{

    public static class CustomEnumExt
    {

        public static string GetAttributeValue(this Enum @enum)
        {
            try
            {
                Type type = @enum.GetType();
                FieldInfo fd = type.GetField(@enum.ToString());
                if (fd == null) { return null; }
                object[] attrs = fd.GetCustomAttributes(typeof(CustomEnum), false);
                string name = string.Empty;
                foreach (CustomEnum attr in attrs)
                {
                    name = attr.value;
                }
                return name;
            }
            catch
            {
                return null;
            }
        }
    }

    public class CustomEnumHelper
    {

        public static List<object> GetEnumKeyValue<T>()
        {
            var result = new List<object>();
            var fds = typeof(T).GetFields();
            for (int i = 0; i < fds.Length; i++)
            {
                if(fds[i].Name!= "value__")
                {
                    result.Add(new { Key = fds[i].Name, Value = (int)fds[i].GetValue(new object()) });
                }
             
            }

            return result;
        }
        public static List<object> GetEnumAttKeyValue<T>()
        {
            var result = new List<object>();
            var fds = typeof(T).GetFields();
            for (int i = 0; i < fds.Length; i++)
            {
                if(fds[i].CustomAttributes.Count()>0)
                {
                    var customEnum = fds[i].GetCustomAttribute(typeof(CustomEnum), false) as CustomEnum;
                    result.Add(new { Key = customEnum.value, Value = (int)fds[i].GetValue(new object()) });
                }
            }

            return result;
        }
    }
}
