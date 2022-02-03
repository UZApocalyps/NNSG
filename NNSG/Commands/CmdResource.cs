﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Commands
{
    class CmdResource : Command
    {
        public CmdResource()
        {
            command = "resources";
            helpMessage = "List the resources";
        }

        public override void Execute(List<string>args)
        {
            UI.getInstance().Write("Food : [" + Warehouse.food.amount + "] Population : [" + Person.people.Count + "] Day : [" + Time.GetInstance().elaspedTime + "]");
        }
    }
}
