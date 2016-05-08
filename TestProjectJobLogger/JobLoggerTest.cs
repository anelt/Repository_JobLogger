using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobLogger.Entities;
using JobLogger.BusinessLayer;
using System.IO;


namespace TestProjectJobLogger
{
    [TestClass]
    public class JobLoggerTest
    {

        LogToDatabase FillForTestDBMessage = new LogToDatabase();
        LogToFile  FillForTestFileMessage = new LogToFile();

        public EMessage FillForTestingMessageDB { get; set; }
        public EMessage FillForTestingMessageFile { get; set; }
      

        [TestInitialize()]
        public void FillData(){
            
            this.FillForTestingMessageDB = new EMessage()
            {
                Description = "Message for test DB",
                Type  = 1              
            };

            this.FillForTestingMessageFile = new EMessage()
            {
                Description = "Message for test File",
                Type = 1
            };

           
        }

        [TestMethod]
        public void LogMessageToDataBase_Insert(){

            //Log to Database 
            FillForTestDBMessage.LogMessage(this.FillForTestingMessageDB);

            //Read the Data that have been saved it 
            EMessage eMsgExpected = FillForTestDBMessage.LoadMessageDataBase(this.FillForTestingMessageDB);

            Assert.AreEqual(this.FillForTestingMessageDB.Description, eMsgExpected.Description);
            Assert.AreEqual(this.FillForTestingMessageDB.Type, eMsgExpected.Type);

        }

        [TestMethod]
        public void LogMessageToFile_VerifyLog(){

            //Log to File Txt 
            FillForTestFileMessage.LogMessage(this.FillForTestingMessageFile);           
            string path = FillForTestFileMessage.PathTest();          
            string[] m = File.ReadAllLines(path);
            string actual = m[m.Length - 1].ToString();

             string Date = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
             string expected = Date + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + "-" + this.FillForTestingMessageFile.Description;

             Assert.AreEqual(expected, actual);
            
        }
      
    }
}
