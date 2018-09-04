using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JiaMiXu.Core
{
   public static class ObjectExt
    {
        public static T ToObject<T>(this object obj, string str)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(str);
            }
            catch {
                return default(T);
            }
        }

        public static string ToJson<T>(this object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch
            {
                return null;
            }
        }
    }
}
