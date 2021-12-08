using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;


namespace NNSG
{
    class Config
    {
        private static Config instance;

        public int firstDay {get; set;}
        public int people {get; set;}
        public int food {get; set;}
        public int farmers {get; set;}

        private Config()
        {
            Config config =  JsonSerializer.Deserialize<Config>(File.ReadAllText("Config.json"));
        }

        public Config getInstance()
        {
            if(instance == null){
                instance = new Config();
            }
            return instance;
        }
    }
}
