using System.Collections.Generic;
using System.Timers;
namespace NNSG
{
    /// <summary>
    /// Keep track of each day for a specific simulation
    /// </summary>
    class Logger
    {
        private static Logger instance;
        /// <summary>
        /// Return the single instance of this class
        /// </summary>
        /// <returns>Singleton of Logger</returns>
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        /// <summary>
        /// Write in log files to keep track on what's going on
        /// </summary>
        /// <param name="oldValues">Resources values before passing a day</param>
        /// <param name="newValues">Resourvces values after</param>
        public void LogDay(Dictionary<string, float> oldValues, Dictionary<string, float> newValues)
        {
            
        }
    }

}