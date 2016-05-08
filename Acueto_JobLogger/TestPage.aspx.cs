using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobLogger.BusinessLayer;
using JobLogger.Entities;

namespace Acueto_JobLogger
{
    public partial class TestPage : System.Web.UI.Page
    {

        public enum TypeLogMessage
        {
            logMessage = 1,
            logWarning = 2,
            logError = 3
        }

      
        public void SaveMessage() {

            EMessage eMessage = new EMessage();
                      
            if (chkError.Checked == true) {
                eMessage.Type = (int)(TypeLogMessage.logError);
                eMessage.Description = txtError.Text.Trim();          
                LogMessage(Convert.ToInt32(ddlTypeLog.SelectedValue), eMessage);
            }
            
            if (chkMessage.Checked==true ){
                eMessage.Type = (int)(TypeLogMessage.logMessage);
                eMessage.Description = txtMessage.Text.Trim();          
                LogMessage(Convert.ToInt32(ddlTypeLog.SelectedValue), eMessage);
            } 
            
            if (chkWarning.Checked == true){
                eMessage.Type = (int)(TypeLogMessage.logWarning);
                eMessage.Description = txtWarning.Text.Trim();          
                LogMessage(Convert.ToInt32(ddlTypeLog.SelectedValue), eMessage);
            }

        }

        public void LogMessage(int typeLog, EMessage eMessage) {

            LogToDatabase logToDB = new LogToDatabase();
            LogToConsole logToConsole = new LogToConsole();
            LogToFile logToFile = new LogToFile();
          
            switch (typeLog)
            {
                case 1:
                    logToDB.LogMessage(eMessage);
                    break;
                case 2:
                    logToFile.LogMessage(eMessage);
                    break;
                case 3:                    
                    logToConsole.LogMessage(eMessage);
                    break;
                default:
                    break;

            }
        }



        protected void btnLogMessage_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMessage.Text == string.Empty)
                {
                    throw new Exception("Fill the message");
                }

                if (Convert.ToInt32(ddlTypeLog.SelectedValue) == 0)
                {
                    throw new Exception("Invalid configuration");
                }

                if (chkError.Checked == false && chkMessage.Checked == false && chkWarning.Checked == false)
                {
                    throw new Exception("Error or Warning or Message must be specified");
                }

                if (Convert.ToInt32(ddlTypeLog.SelectedValue)==3) {
                    throw new Exception("Test this in the console project --> ConsoleTestLogApp..");
              
                
                }

                SaveMessage(); 

            }
            catch (Exception ex)
            {
                string script = @"<script type='text/javascript'>
                            alert('{0}');
                        </script>";

                script = string.Format(script, ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", script, false);
            }


        }


        
    }
}