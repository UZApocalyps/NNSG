using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdJob : Command
    {
        public CmdJob(string cmd,string help)
        {
            command = cmd;
            helpMessage = help;
        }
        public override void Execute(List<string> args)
        {
            foreach (var job in Job.jobs)
            {
                UI.getInstance().Write(job.Key.ToString() + ": " + job.Value.persons.Count.ToString());
            }
        }
    }
}
