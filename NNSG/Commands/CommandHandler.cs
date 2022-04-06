using NNSG.Commands;
using System.Collections.Generic;

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
            string[] args = UI.getInstance().Read().Split(" ");
            List<string> arguments = new List<string>();
            if (Command.commands.ContainsKey(args[0]))
            {
                for (int i = 1; i < args.Length; i++)
                {
                    arguments.Add(args[i]);
                }
                Command.commands[args[0]].Execute(arguments);

            }
            else
            {

                UI.getInstance().Write("Unknown command please type 'help' to see all available commands");

            }


        }
    }
}
