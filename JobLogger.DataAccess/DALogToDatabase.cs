using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using JobLogger.Entities;
using System.Data.Common;

namespace JobLogger.DataAccess
{
    public class DALogToDatabase {


        public string Connection(){
            string sCnnConfiguration = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            return sCnnConfiguration;
        }


        public void LogMessage(EMessage Message){
            try
            {
                SqlConnection cnn = new SqlConnection(Connection());
                cnn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Log Values('" + Message.Description + "', " + Message.Type + ")", cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex){
                throw new Exception("Error: " + ex);                
            }

        }

        // For Unit Test 
        public EMessage LoadMessageDataBase(EMessage Message) { 
                EMessage eMessage = new EMessage();
             try
            {
                SqlConnection cnn = new SqlConnection(Connection());
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from Log where Message ='" + Message.Description + "' And Type="+ Message.Type, cnn);
                DbDataReader sDR = cmd.ExecuteReader();
                while (sDR.Read())
                {
                    eMessage.Description = (sDR["Message"].ToString());
                    eMessage.Type = Convert.ToInt32(sDR["Type"]);

                }
                return eMessage;
            }
             catch (Exception ex)
             {
                 throw new Exception("Error: " + ex);
             }

        }

    }
}