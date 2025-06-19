using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ConsoleLogger: Interfaces.ILogger
    {
        public void Log(string toLog)
        {
            Console.WriteLine("done");
        }
    }
}
