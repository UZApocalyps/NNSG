using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdSkipDay : Command
    {
        public static bool trigger = false;
        public CmdSkipDay()
        {
            command = "next";
            helpMessage = "Skip the day. You can add a number after the command to skip a specific ammount of days : next 30";
        }

        public override void Execute(List<string> args)
        {
            int days = 0;
            if (args.Count >= 1)
            {
                for (int i = 0; i < int.Parse(args[0]); i++)
                {
                    Time.GetInstance().TickAll();
                    if (trigger)
                    {
                        trigger = false;
                        break;
                    }
                    days++;
                }
                UI.getInstance().Write(days + " days have gone");
            }
            else
            {
                float lastFoodValue = Warehouse.food.amount;
                Time.GetInstance().TickAll();
                UI.getInstance().Write("A new day has come");
            }
            Command.commands["resources"].Execute(null);
        }
    }
}
