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
            string[] args = UI.getInstance().Read().Split(" ");
            List<string> arguments = new List<string>();
            for (int i = 1; i < args.Length; i++)
            {
                arguments.Add(args[i]);
            } 
            Commands.Command.commands[args[0]].Execute(arguments);
        }
    }
}
