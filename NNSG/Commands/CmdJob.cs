using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdJob : Command
    {

        public CmdJob()
        {
            command = "jobs";
            helpMessage = "List all the jobs with the number of workers";
        }
        public override void Execute(List<string> args)
        {
            UI.getInstance().Write("Farmers : " + Person.people.FindAll(f => f.job is Farmer).Count);
            UI.getInstance().Write("Tailors : " + Person.people.FindAll(f => f.job is Tailor).Count);
        }
    }
}
