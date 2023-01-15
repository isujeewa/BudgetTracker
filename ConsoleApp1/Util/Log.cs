using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Util
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    public sealed class Logger
    {
        
        private static  Logger logger = new Logger();

        // Constructor is private -- cannot use new
        private Logger()
        {

        }
      
        //method to initializ the instance
       public static Logger GetLogger()
        {
            // Uses lazy initialization.
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
