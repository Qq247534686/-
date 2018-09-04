using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JiaMiXiu.Domain
{
    public class EF_Factory
    {
        private static  object obj = new object();

        private static DbContext Db { get; set; }

        public static DbContext GetDb() {
            lock (obj)
            {
                if (Db == null) 
                {
                    Db = new EF_DBContext();
                }
            }
            return Db;
        }
    }
}