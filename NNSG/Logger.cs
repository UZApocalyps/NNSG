using System.Collections.Generic;
using System.Timers;
namespace NNSG
{
    /// <summary>
    /// Keep track of each day
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
    }
}