using System;

namespace SingletonDemo
{
    // Logger class that follows the Singleton pattern
    public class AppLogger
    {
        // Holds the single instance
        private static AppLogger? _loggerInstance;

        // Object for thread safety
        private static readonly object _lockObj = new();

        // Private constructor to restrict object creation
        private AppLogger() { }

        // Public method to get the same instance every time
        public static AppLogger GetLogger()
        {
            if (_loggerInstance == null)
            {
                lock (_lockObj)
                {
                    if (_loggerInstance == null)
                    {
                        _loggerInstance = new AppLogger();
                    }
                }
            }
            return _loggerInstance;
        }

        // A simple log function
        public void WriteLog(string message)
        {
            Console.WriteLine("LOG >> " + message);
        }
    }

    class Program
    {
        static void Main()
        {
            var logger1 = AppLogger.GetLogger();
            var logger2 = AppLogger.GetLogger();

            logger1.WriteLog("System is starting up...");
            logger2.WriteLog("System is running tasks...");

            Console.WriteLine("Same object used? " + (logger1 == logger2));
        }
    }
}
