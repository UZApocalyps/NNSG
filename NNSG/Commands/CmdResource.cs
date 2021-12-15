﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdResource : Command
    {
        public CmdResource(string cmd, string help)
        {
            command = cmd;
            helpMessage = help;
        }

        public override void Execute(List<string>args)
        {
            UI.getInstance().Write("Food : [" + Warehouse.food.ammount + "] Population : [" + Person.people.Count + "] Day : [" + Time.GetInstance().elaspedTime + "]");
        }
    }
}