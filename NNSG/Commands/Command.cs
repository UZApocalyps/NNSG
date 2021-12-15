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
    }
}
