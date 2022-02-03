using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NNSG.Events
{
    class Meteor : Disaster
    {
        int luck = 10000;

        private string[] messages;

        public Meteor()
        {
            Time.GetInstance().Subscribe(this);
            Dictionary<string, object> oui = JsonConvert.DeserializeObject<Dictionary<string,object>>(File.ReadAllText("lang/fr.json"));
            Dictionary<string, object> non = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(oui["meteor"].ToString()));
            
            messages[0] = "";

        }

        public override void Ticking()
        {
            if (new Random().Next(0,luck) == luck )
            {
                //PAAAAAAAAAAAANNNNNNNNNNNNNNNNNNNNNIIIIIIIIIIIIIIIIIC

            }
        }
    }
}
