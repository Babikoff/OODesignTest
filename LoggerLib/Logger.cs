using Contracts;
using System;

namespace LoggerLib
{
    public class Logger : ILogger
    {
        public void LogException(Exception e)
        {
            Console.WriteLine("Logged: " + e.Message);
        }
    }
}
