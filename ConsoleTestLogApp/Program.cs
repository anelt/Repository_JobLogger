using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobLogger.BusinessLayer;
using JobLogger.Entities;
namespace ConsoleTestLogApp
{
    class Program
    {

        public enum TypeLogMessage
        {
            logMessage = 1,
            logWarning = 2,
            logError = 3
        }

        static void Main(string[] args)
        {
            int read= Convert.ToInt32(Console.ReadLine());
            EMessage eMessage = new EMessage();          

            switch (read) { 
                case (int)TypeLogMessage.logError:
                     eMessage.Description = "Error Console";
                     eMessage.Type = (int)TypeLogMessage.logError;
                    break;
                case (int)TypeLogMessage.logMessage:
                     eMessage.Description = "Message Console";
                     eMessage.Type = (int)TypeLogMessage.logMessage;
                    break;
                case (int)TypeLogMessage.logWarning:
                     eMessage.Description = "Warning Console";
                     eMessage.Type = (int)TypeLogMessage.logWarning;
                    break; 
                default:
                    break;

            }
                     

            LogToConsole logToConsole = new LogToConsole();
            logToConsole.LogMessage(eMessage);

           

        }
    }
}
