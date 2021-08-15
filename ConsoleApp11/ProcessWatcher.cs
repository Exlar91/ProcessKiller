using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessKiller
{
    class ProcessWatcher
    {
        readonly string ProcessName;
        readonly int ProcessLifeTime;
        readonly int TimeToCheck;
        public ILogWriter logwriter;

        public ProcessWatcher(string _processname, int _processlifetime, int _timetocheck, ILogWriter _logwriter)
        {
            this.ProcessLifeTime = _processlifetime;
            this.ProcessName = _processname;
            this.TimeToCheck = _timetocheck;
            this.logwriter = _logwriter;
        }


        public void Kill()
        {
            bool a = true;
            while (a = true)
            {
                foreach (var process in Process.GetProcessesByName(ProcessName))
                {
                       Console.WriteLine(process.ProcessName);
                       if ((DateTime.Now - process.StartTime).TotalMinutes >= ProcessLifeTime)
                       {
                           logwriter.WriteLog(DateTime.Now.ToString(), ProcessName);
                           process.Kill();
                           Console.WriteLine($"[{DateTime.Now}]: Process: {process.ProcessName} is closed");
                      
                       }
                      
                }

        Thread.Sleep(TimeToCheck * 60000);

            }
        }

    }
}

