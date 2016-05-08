using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobLogger.Entities;
using System.Diagnostics;

namespace JobLogger.DataAccess
{
    public class DALogToConsole
    {

        public enum TypeLogMessage
        {
            logMessage = 1,
            logWarning = 2,
            logError = 3
        }

         public void LogMessage(EMessage Message){
          
            try
            {
                switch (Message.Type) {                 
                    case (int)TypeLogMessage.logError:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break; 
                    case (int)TypeLogMessage.logMessage:
                        Console.ForegroundColor = ConsoleColor.White;
                        break; 
                    case (int)TypeLogMessage.logWarning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break; 
                    default:
                        break;
                
                }
                                            
               Console.WriteLine(DateTime.Now.ToShortDateString() +"-" + Message.Description);
               Console.ReadKey();

             
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex);
            }
        
        }

     

    }
}
