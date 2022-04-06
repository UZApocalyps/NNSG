using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdRestart : Command
    {
        public CmdRestart()
        {
            command = "restart";
            helpMessage = "Restart the game";
        }
        public override void Execute(List<string> args)
        {
            GameManager.GetInstance().Restart();
        }
    }
}
