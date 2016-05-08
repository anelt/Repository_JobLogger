using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobLogger.Entities;
using JobLogger.DataAccess;

namespace JobLogger.BusinessLayer
{
    public class LogToConsole : IJobLogger {

        DALogToConsole _DALogToConsole = new DALogToConsole();

        public void LogMessage(EMessage Message){
            _DALogToConsole.LogMessage(Message);
        }
    }
}