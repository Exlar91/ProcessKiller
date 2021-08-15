using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ProcessKiller
{
    public class LogWriter : ILogWriter
    {

        public void WriteLog(string data, string pr_name)
        {
            if (!File.Exists("ProcessKiller.log"))
            {
                StreamWriter sw = File.CreateText("ProcessKiller.log");
                sw.WriteLine($"[{data}]: Process: {pr_name} is closed");
                sw.Close();
            }
            else
            {
                List<string> ReadedText = (File.ReadAllLines("ProcessKiller.log")).ToList();
                ReadedText.Add($"[{data}]: Process: {pr_name} is closed");
                File.WriteAllLines("ProcessKiller.log", ReadedText.ToArray());
            }
        }


    }
}
