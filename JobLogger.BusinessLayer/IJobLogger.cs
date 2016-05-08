using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobLogger.Entities;

namespace JobLogger.BusinessLayer
{
    public interface IJobLogger{

       void LogMessage(EMessage Message);        

    }
}