using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdHappiness : Command
    {
        public CmdHappiness()
        {
            command = "happiness";
            helpMessage = "Show the current value of global happiness of your population";
        }

        public override void Execute(List<string> args)
        {
            UI.getInstance().Write("Global happiness : " + Person.GetGlobalHappiness().ToString());
        }
    }
}
