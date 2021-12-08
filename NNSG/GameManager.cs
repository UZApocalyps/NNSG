using System;
using System.Collections.Generic;
using System.Text;
using NNSG.Needs;
using NNSG.Jobs;
using System.Threading;
namespace NNSG
{
    public class GameManager
    {
        private static GameManager instance;
        private Config config;
        private GameManager()
        {
            //TODO instanciate objects
            config = Config.getInstance();
        }

        public static GameManager GetInstance()
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }

        /// <summary>
        /// Instantiate
        /// </summary>
        public void StartGame()
        {
            //Instanciate Time
            Time timer = Time.GetInstance();
            timer.elaspedTime = config.firstDay;
            //Start timer 
            //TODO

            //Instanciate Goods
            Good food = new Good();
            food.name = "food";
            food.type = GoodType.Food;
            food.ammount = config.food;
            food.price = 1;
            Warehouse.food = food;

            //Instanciate Job
            Job job = new Job(GoodType.Food);
            job.Name = "Farmer";
            job.persons = new List<Person>();
            job.quantityPerTick = 1;

            //Instanciate Person

            for (int i = 0; i < config.people; i++)
            {
                Person person = new Person();
                person.id = new Random().Next(0,int.MaxValue);
                person.age = new Random().Next(10, 50);
                if (i < config.farmers)
                {
                    person.job = job;
                    job.persons.Add(person);
                }
                Person.people.Add(person);

                Hunger hunger = new Hunger();
                hunger.name = "hunger";
                hunger.level = new Random().Next(0, 100);

                person.needs = new Need[1];
                person.needs[(int)NeedsType.hunger] = hunger;

            }

            UI.getInstance().Write("Game is starting ...");
            //timer.StartTimer();
            KeepConsoleAlive();
        }

        private void KeepConsoleAlive()
        {
            while (Time.GetInstance() != null)
            {
                UI.getInstance().PrintArrow();
                string command = UI.getInstance().Read();
                switch (command)
                {
                    case "resources":
                        UI.getInstance().Write("Food : [" + Warehouse.food.ammount + "] Population : ["+Person.people.Count+"] Day : ["+Time.GetInstance().elaspedTime+"]");
                        break;
                    case "next":
                        Time.GetInstance().TickAll();
                        UI.getInstance().Write("A new day has come");
                        break;
                    default:
                        break;
                }
                string[] splitCommand = command.Split(' ');
                if (splitCommand.Length > 1)
                {
                    if (splitCommand[0] == "next")
                    {
                        for (int i = 0; i < int.Parse(splitCommand[1]); i++)
                        {
                            Time.GetInstance().TickAll();

                        }
                        UI.getInstance().Write(int.Parse(splitCommand[1]) + " days have gone");

                    }
                }
            }
        }
    }
}
