using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobLogger.Entities;
using System.IO;
using System.Configuration; 

namespace JobLogger.DataAccess
{

    public class DALogToFile
    {

        public string PathTest()
        {
            string Date = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            string path = ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + Date + ".txt";
            return path;
            
        }


        public void LogMessage(EMessage Message)
        {
            string Date = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            string path = ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + Date + ".txt";
            string text = "";
              
            try
            {                
                  text = Date +"_" + DateTime.Now.Hour.ToString()+DateTime.Now.Minute.ToString()+ "-" + Message.Description + Environment.NewLine;

                  if (!File.Exists(path))
                  {
                      File.WriteAllText(path, text);
                  }
                  else {
                      File.AppendAllText(path, text);

                  }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex);
            }

        }
    }
}