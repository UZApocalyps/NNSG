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
                default:
                    break;
            }
            NextDay(command);
           
        }

        private static void PrintResources()
        {
            UI.getInstance().Write("Food : [" + Warehouse.food.ammount + "] Population : [" + Person.people.Count + "] Day : [" + Time.GetInstance().elaspedTime + "]");
        }

        private static void NextDay(string command)
        {
            string[] splitCommand = command.Split(' ');
            if (splitCommand.Length > 1)
            {
                if (splitCommand[0] == "next")
                {
                    for (int i = 0; i < int.Parse(splitCommand[1]); i++)
                    {
                        Time.GetInstance().TickAll();
                    }
                    UI.getInstance().Write(int.Parse(splitCommand[1]) + " days have gone");
                }
            }
        }
        private static void NextDay()
        {
            int lastFoodValue = Warehouse.food.ammount;
            Time.GetInstance().TickAll();
            UI.getInstance().Write("A new day has come");

        }
    }
}
