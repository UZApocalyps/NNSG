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
        /// <param name="newValues">Resources values after</param>
        public static void LogDay(Dictionary<string, float> oldValues, Dictionary<string, float> newValues)
        {
            string mdr = GenerateLogLine(newValues["Food"] - oldValues["Food"], newValues["Furniture"] - oldValues["Furniture"], newValues["Vehicle"] - oldValues["Vehicle"], newValues["Cloth"] - oldValues["Cloth"], newValues["People"] - oldValues["People"]);
        }

        public static string GenerateLogLine(float foodDiff, float furnitureDiff, float vehicleDiff, float clothDiff, float populationDiff)
        {
            return "Food : [" + Warehouse.food.amount + " (" + Tools.ShowDiff(foodDiff) + ")] "
                + " Furnitures : [" + Warehouse.furniture.amount + " (" + Tools.ShowDiff(furnitureDiff) + ")] "
                + " vehicles : [" + Warehouse.vehicles.amount + " (" + Tools.ShowDiff(vehicleDiff) + ")] "
                + " clothes : [" + Warehouse.clothes.amount + " (" + Tools.ShowDiff(clothDiff) + ")] "
                + " Population : [" + Person.people.Count + " (" + Tools.ShowDiff(populationDiff) + ")] "
                + " Day : [" + Time.GetInstance().elaspedTime + "]";
        }
    }
}