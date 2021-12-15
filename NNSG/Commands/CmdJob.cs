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
            foreach (var job in Job.jobs)
            {
                UI.getInstance().Write(job.Key.ToString() + ": " + job.Value.persons.Count.ToString());
            }
        }
    }
}
