using System;
using System.Collections.Generic;
using System.Text;
using NNSG.Needs;
using NNSG.Jobs;
using System.Threading;
using NNSG.Commands;

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

            Command.RegisterCommands();
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
            CreateTimer(config.firstDay);

            CreateGoods();

            AddFood(config.food);

            AddPeople(config.people);

            AddFarmers(config.farmers);
            
            UI.getInstance().Write("Game is starting ...");
            KeepConsoleAlive();
        }
        public void Restart()
        {
            Warehouse.food = null;
            Person.people.Clear();
            StartGame();
        }
        private void KeepConsoleAlive()
        {
            CommandHandler.handle();
        }


        /// <summary>
        /// Create timer and start it 
        /// </summary>
        /// <param name="startTime">Begin day</param>
        private void CreateTimer(int startTime)
        {
            Time timer = Time.GetInstance();
            timer.elaspedTime = startTime;
            //timer.StartTimer();

        }

        private void CreateGoods()
        {
            Good food = new Good();
            food.name = "food";
            food.type = GoodType.Food;
            food.ammount = 0;
            food.price = 1;
            Warehouse.food = food;
        }

        /// <summary>
        /// Add food 
        /// </summary>
        /// <param name="ammount">Ammount of food to add</param>
        private void AddFood(int ammount)
        {
            
            Warehouse.food.ammount += ammount;
        }


        /// <summary>
        /// Add specific ammount of farmers
        /// </summary>
        /// <param name="farmers">Ammount of farmers you want to add</param>
        private void AddFarmers(int farmers)
        {
            int addedFarmers = 0;
            Farmer farmer = Farmer.GetInstance();
            foreach (var person in Person.people.FindAll(person=> person.job == null))
            {
                person.AddJob(farmer);
                addedFarmers++;
                if (addedFarmers >= farmers)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Add new people to population
        /// </summary>
        /// <param name="ammount"></param>
        private void AddPeople(int ammount)
        {
            for (int i = 0; i < ammount; i++)
            {
                Person person = new Person();
                person.id = Randomizer.Range(0,int.MaxValue);
                person.age = Randomizer.Range(10, 50);
                Person.people.Add(person);

                

                person.needs = new Need[1];
                person.needs[(int)NeedsType.hunger] = AddHunger(0);

            }
        }

        /// <summary>
        /// Create a hunger need
        /// </summary>
        /// <param name="level">Level of need</param>
        /// <returns>Hunger need</returns>
        private Hunger AddHunger(int level)
        {
            Hunger hunger = new Hunger();
            hunger.name = "hunger";
            hunger.level = level;

            return hunger;
        }
    }
}
