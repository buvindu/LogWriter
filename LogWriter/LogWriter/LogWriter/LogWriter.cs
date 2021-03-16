using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWriter
{
    public static class LogWriter
    {       
        public static void WriteLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory+@"\Log");
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Log\"+DateTime.Now.ToString("yyyy-MM-dd"));
                //sw = new StreamWriter(@"D:\Logfile.txt", true);
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\Log\" + DateTime.Now.ToString("yyyy-MM-dd") + @"\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "_Log.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + " : " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }
        public static void WriteErrors(string Message)
        {
            StreamWriter sw = null;
            try
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\ErrorLog");
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\ErrorLog\" + DateTime.Now.ToString("yyyy-MM-dd"));
                //sw = new StreamWriter(@"D:\Logfile.txt", true);
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\ErrorLog\" + DateTime.Now.ToString("yyyy-MM-dd") + @"\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString() + "_ErrorLog.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + " : " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }
        public static void WriteFileDocumentWise(string DocNum,string FileName,string Name,string value)
        {
            StreamWriter sw = null;
            try
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\" + FileName);
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\"+FileName+@"\" + DateTime.Now.ToString("yyyy-MM-dd"));
                //sw = new StreamWriter(@"D:\Logfile.txt", true);
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\" + FileName + @"\" + DateTime.Now.ToString("yyyy-MM-dd") + @"\" + FileName + "_" + DocNum + ".txt", true);
                sw.WriteLine(Name + " : " + value);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }
    }
}
