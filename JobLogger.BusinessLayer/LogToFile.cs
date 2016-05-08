using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobLogger.DataAccess;
using JobLogger.Entities;

namespace JobLogger.BusinessLayer
{
    public class LogToFile : IJobLogger{
        DALogToFile _DALogToFile = new DALogToFile();

        public string PathTest() {
            return _DALogToFile.PathTest();
        }

        public void LogMessage(EMessage Message){
            _DALogToFile.LogMessage(Message);
        }

    }
}