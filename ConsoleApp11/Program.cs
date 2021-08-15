using System;
using System.Threading;


namespace ProcessKiller
{
    class Program
    {
        static void Main(string[] arg)
        {
            
            LogWriter LW = new LogWriter();
            ProcessWatcher PW = new ProcessWatcher(arg[0], Convert.ToInt32(arg[1]), Convert.ToInt32(arg[2]), LW);
            //ProcessWatcher PW = new ProcessWatcher("notepad", 2, 1, LW);
            PW.Kill();
            Console.ReadKey();



        }
    }

    
}
