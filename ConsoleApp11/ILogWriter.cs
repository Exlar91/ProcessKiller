namespace ProcessKiller
{
    public interface ILogWriter
    {
        void WriteLog(string data, string pr_name);
    }
}