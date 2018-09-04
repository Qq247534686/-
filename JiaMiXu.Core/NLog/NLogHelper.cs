using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvc.Core
{
    public class NLogHelper
    {
        private static Logger logger_Email = LogManager.GetLogger("SendMail");

        private static Logger logger_File = LogManager.GetLogger("Log_file");

        private static Logger logger_Db = LogManager.GetLogger("DatabaseFile");

        public static void WriteError(string ex)
        {
            logger_File.Error(ex);
        }

        public static void WriteInfo(string ex)
        {
            logger_File.Info(ex);
        }

        public static void SendEmail(string ex)
        {
            logger_Email.Error(ex);
        }
        public static void InsertDb(string ex)
        {
            logger_Db.Error(ex);
        }

    }
}