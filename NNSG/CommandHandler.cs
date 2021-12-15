using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    class CommandHandler
    {
        public static void handle()
        {
            while (Time.GetInstance() != null)
            {
                UI.getInstance().PrintArrow();
                InterceptCommand();
            }
        }

        private static void InterceptCommand()
        {
            string command = UI.getInstance().Read();
            switch (command)
            {
                case "resources":
                    PrintResources();
                    break;
                case "next":
                    NextDay();
                    break;
                case "restart":
                    GameManager.GetInstance().Restart();
                    break;
                case "jobs":
                    PrintJobs();
                    break;
                default:
                    break;
            }
            NextDay(command);
           
        }

        private static void PrintJobs()
        {
            UI.getInstance().Write("Jobs: ");
            foreach (var job in Job.jobs)
            {
                UI.getInstance().Write(job.Key.ToString() + ": " + job.Value.persons.Count.ToString());
            }
        }

        private static void PrintResources()
        {
        }

        private static void NextDay(string command)
        {
           
        }
        private static void NextDay()
        {
            int lastFoodValue = Warehouse.food.ammount;
            Time.GetInstance().TickAll();
            UI.getInstance().Write("A new day has come");

        }
    }
}
