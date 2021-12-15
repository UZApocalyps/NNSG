using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdRestart : Command
    {
        public CmdRestart(string cmd, string help)
        {
            command = cmd;
            helpMessage = help;
        }
        public override void Execute(List<string> args)
        {
            GameManager.GetInstance().Restart();
        }
    }
}
