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

        public override void Execute(List<string> args)
        {
            if (args.Count > 1)
            {
                float foodDiff = (Warehouse.food.amount - float.Parse(args[1]));
                float furnitureDiff = (Warehouse.furniture.amount - float.Parse(args[2]));
                float vehicleDiff = (Warehouse.vehicles.amount - float.Parse(args[3]));
                float clothDiff = (Warehouse.clothes.amount - float.Parse(args[4]));
                float populationDiff = (Person.people.Count - float.Parse(args[5]));

                UI.getInstance().Write(Logger.GenerateLogLine(foodDiff, furnitureDiff, vehicleDiff, clothDiff, populationDiff));
            }
            else // Only print current values
            {
                UI.getInstance().Write(
                    "Food : [" + Warehouse.food.amount + "] "
                    + "Furnitures : [" + Warehouse.furniture.amount + "] "
                    + "vehicles : [" + Warehouse.vehicles.amount + "] "
                    + "clothes : [" + Warehouse.clothes.amount + "] "
                    + "Population : [" + Person.people.Count + "] "
                    + "Day : [" + Time.GetInstance().elaspedTime + "]");
            }
        }
    }
}
