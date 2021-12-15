using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdHelp : Command
    {
        public CmdHelp()
        {
            command = "help";
            helpMessage = "List all avaible commands";
        }
        public override void Execute(List<string> args)
        {
            string result = "";
            foreach (var item in Command.commands)
            {
                result += "[" + item.Value.command + "] " + item.Value.helpMessage + "\n";
            }
            UI.getInstance().Write(result);
        }
    }
}
