using System;
using System.Collections.Generic;
using System.Text;
using NNSG.Needs;
using NNSG.Jobs;
using NNSG.Goods;
using System.Threading;
using NNSG.Commands;
using NNSG.Events;

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

            CreateEvents();

            CreateGoods();

            AddPeople(config.people);

            AddFarmers(config.farmers);

            AddTailors(config.tailors);

            CreatePopulation();
            
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
        }

        /// <summary>
        /// Instanciate all events that can happen in the game
        /// </summary>
        private void CreateEvents()
        {
            Meteor meteor = new Meteor();
            Insurrection insurrection = new Insurrection();
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
        /// Create goods and set their amount & price
        /// </summary>
        /// <param name="amountValue">The total of the good</param>
        /// <param name="priceValue">The price of the good</param>
        private void CreateGoods()
        {      
            Warehouse.food = new Food(config.food, 1);
            Warehouse.clothes = new Clothes(config.clothes, 10);
            Warehouse.vehicles = new Vehicles(config.vehicles, 1000);
            Warehouse.furniture = new Furniture(config.furniture, 100);
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

        private void AddTailors(int tailors)
        {

        }

        /// <summary>
        /// Add new people to population
        /// </summary>
        /// <param name="ammount"></param>
        private void AddPeople(int ammount)
        {
            for (int i = 0; i < ammount; i++)
            {
                Person.people.Add(new Person());              
            }
        }

        private void CreatePopulation()
        {
            new Population();
        }
    }
}
