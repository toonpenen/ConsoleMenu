using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuLib
{
    static internal class StaticLogger
    {
        private static DirectoryInfo actualLogFileDirectory = new DirectoryInfo(Environment.CurrentDirectory + @"\LOG");
        private static FileInfo actualLogFile = new FileInfo(actualLogFileDirectory.FullName + @"\LogSession_" + (DateTime.Now.ToString()).Replace(':', '-') + ".txt");
        private static bool firstLogAttempt = true;

        public static OperationInfo LogToFile(string logLine)
        {
            if (firstLogAttempt)
            {
                if (!actualLogFileDirectory.Exists) actualLogFileDirectory.Create();
                if (!actualLogFile.Exists)
                {
                    try
                    {
                        OrderLogFolder();
                        actualLogFile.Create().Dispose();
                    }
                    catch (Exception ex)
                    {
                        return new OperationInfo(InformationType.Exception, ex.Message);
                    }
                }
                firstLogAttempt = false;
            }

            try
            {
                using (StreamWriter sw = actualLogFile.AppendText())
                {
                    sw.WriteLine(logLine);
                }
                return new OperationInfo(InformationType.ConfirmationWithoutMessage, "");
            }
            catch (Exception ex)
            {
                return new OperationInfo(InformationType.Exception, ex.Message);
            }
        }
        private static void OrderLogFolder()
        {
            IEnumerable<FileInfo> files = actualLogFileDirectory.EnumerateFiles();
            IEnumerable<FileInfo> orderedFiles = files.OrderBy(file => file.CreationTime);

            while (files.Count() >= 3)
            {
                orderedFiles.ElementAt(0).Delete();
            }
        }
    }
}