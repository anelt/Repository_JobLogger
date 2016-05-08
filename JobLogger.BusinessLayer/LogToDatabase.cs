using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using JobLogger.DataAccess;
using JobLogger.Entities;


namespace JobLogger.BusinessLayer
{
    public class LogToDatabase : IJobLogger 
    {
        DALogToDatabase _DALogToDatabase = new DALogToDatabase();

        public void LogMessage(EMessage Message){
            _DALogToDatabase.LogMessage(Message);

        }

        public EMessage LoadMessageDataBase(EMessage Message)
        {
            return _DALogToDatabase.LoadMessageDataBase(Message);
        }

    }
}