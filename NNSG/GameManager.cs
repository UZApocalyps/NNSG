using System;
using System.Collections.Generic;
using System.Text;
using NNSG.Needs;
using NNSG.Jobs;
using NNSG.Goods;
using System.Threading;
using NNSG.Commands;
using NNSG.Events;
using NNSG.lang;
using Newtonsoft.Json;
using System.IO;

namespace NNSG
{
    /// <summary>
    /// Initialize every systems and manages simulation instances
    /// </summary>
    public class GameManager
    {
        private static GameManager instance;
        private List<Job> allJobs = new List<Job>();

        private Config config;
        private GameManager()
        {
            allJobs.Add(Tailor.GetInstance());
            allJobs.Add(Artisan.GetInstance());
            allJobs.Add(Farmer.GetInstance());
            allJobs.Add(Mechanic.GetInstance());

            config = Config.getInstance();
            Console.OutputEncoding = Encoding.UTF8;
            if (!Command.loaded)
            {
                Command.RegisterCommands();
            }
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
            LoadLang();

            CreateTimer(config.firstDay);

            CreateGoods();

            AddPeople(config.people);

            CreatePopulation();

            AddWorkers<Farmer>(config.farmers);
            AddWorkers<Tailor>(config.tailors);
            AddWorkers<Artisan>(config.artisans);
            AddWorkers<Mechanic>(config.mechanicians);

            new Meteor();

            new Earthquake();

            new Fire();

            new Insurrection();
            
            UI.getInstance().Write("Game is starting ...");
            KeepConsoleAlive();
        }

        public void LoadLang()
        {
            Lang.SetInstance(JsonConvert.DeserializeObject<Lang>(File.ReadAllText("lang/fr.json")));
        }
        public void Restart()
        {
            Warehouse.food = null;
            Warehouse.furniture = null;
            Warehouse.vehicles = null;
            Warehouse.clothes = null;
            Person.people.Clear();
            instance = null;
            GameManager gameManager = new GameManager();
            gameManager.StartGame();
        }
        public void End()
        {
            UI.getInstance().PrintLoose();
            Restart();
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
        /// Create jobs given the configuration
        /// </summary>
        /// <typeparam name="T">The type of the job</typeparam>
        /// <param name="workers">The amount of f</param>
        private void AddWorkers<T>(int workers) where T : Job
        { 
            foreach (Job job in allJobs)
            {
                if (job is T)
                {
                    int addedWorkers = 0;
                    foreach (var person in Person.people.FindAll(person => person.job == null))
                    {
                        person.AddJob(job);
                        addedWorkers++;
                        if (addedWorkers >= workers)
                        {
                            break;
                        }
                    }
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
                Person.people.Add(new Person());
            }
        }

        private void CreatePopulation()
        {
            new Population();
        }
    }
}
