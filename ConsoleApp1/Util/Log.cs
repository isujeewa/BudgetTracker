using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Util
{
    public sealed class Logger
    {
        private static  Logger logger = new Logger();

       private class
       public static Logger GetLogger()
        {
            if (logger == null)
            {
                Logger.logger = new Logger();
            }

            return logger;
        }

        public void log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
