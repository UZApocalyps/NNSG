using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdSkipDay : Command
    {
        public CmdSkipDay(string cmd, string help)
        {
            command = cmd;
            helpMessage = help;
        }

        public override void Execute(List<string> args)
        {
            if (args.Count >= 1)
            {
                for (int i = 0; i < int.Parse(args[0]); i++)
                {
                    Time.GetInstance().TickAll();
                }
                UI.getInstance().Write(int.Parse(args[0]) + " days have gone");
            }
            else
            {
                int lastFoodValue = Warehouse.food.ammount;
                Time.GetInstance().TickAll();
                UI.getInstance().Write("A new day has come");
            }
        }
    }
}
