using System;
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
            UI.getInstance().Write("Food : [" + Warehouse.food.amount + "] Furnitures : ["+Warehouse.furniture.amount+ "] vehicles : [" + Warehouse.vehicles.amount + "] " +
                "clothes : [" + Warehouse.clothes.amount + "] Population : [" + Person.people.Count + "] Day : [" + Time.GetInstance().elaspedTime + "]");
        }
    }
}
