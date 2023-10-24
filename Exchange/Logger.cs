using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    public class Logger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
            
        }
    }
}
