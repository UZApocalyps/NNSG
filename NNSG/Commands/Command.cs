using System.Collections.Generic;

namespace NNSG.Commands
{
    abstract class Command
    {
        public static Dictionary<string,Command> commands = new Dictionary<string,Command>();

        public string command;
        public List<string> arguments = new List<string>();
        public string helpMessage;
        public abstract void Execute(List<string>args);

        public static void RegisterCommands()
        {
            Command.commands.Add("jobs", new CmdJob());
            Command.commands.Add("resources", new CmdResource());
            Command.commands.Add("restart", new CmdRestart());
            Command.commands.Add("next", new CmdSkipDay());
        }
    }
}
