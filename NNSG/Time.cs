using System.Collections.Generic;
using System.Timers;
namespace NNSG
{
    /// <summary>
    /// Triggers a tick at desired moment or at regular intervals on all class implementing the ITick interface
    /// </summary>
    class Time
    {
        private static Time instance;
        /// <summary>
        /// Return the single instance of this class
        /// </summary>
        /// <returns>Single instance of class Time </returns>
        public static Time GetInstance()
        {
            if (instance == null)
            {
                instance = new Time();
            }

            return instance;
        }

        /// <summary>
        /// Defines how much time should pass between each tick.
        /// Changes to this value will take effect at the next tick
        /// 1 / [tick per second]
        /// </summary>
        private float tickInterval = 1 / 1f; // 1 second between each ticks

        private Timer tickTimer;

        /// <summary>
        /// Tracks how much time has elapsed
        /// </summary>
        public int elaspedTime = 0;

        /// <summary>
        /// List of subscribed item that implements ITick interface
        /// </summary>
        List<ITick> subscribers = new List<ITick>();

        /// <summary>
        /// Subscribe an object to the observer
        /// </summary>
        /// <param name="newSubscriber">Class that implements ITick interface</param>
        public void Subscribe(ITick newSubscriber)
        {
            if (!subscribers.Contains(newSubscriber))
                subscribers.Add(newSubscriber);
        }

        /// <summary>
        /// Unsubscribe an object from the observer
        /// </summary>
        /// <param name="oldSubscriber">Class that implements ITick interface</param>
        public void Unsubscribe(ITick oldSubscriber)
        {
            subscribers.Remove(oldSubscriber);
        }

        /// <summary>
        /// Makes the simulation advance by 1 step forward
        /// </summary>
        private void OnTick(object source, ElapsedEventArgs e)
        {
            TickAll();

            // If tick intreval has changed
            if (tickTimer.Interval != tickInterval)
                tickTimer.Interval = tickInterval;
        }

        public void TickAll()
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                if (subscribers[i] != null)
                {
                    subscribers[i].Ticking();
                }

            }
            foreach (ITick subscriber in subscribers)
            {
            }
            elaspedTime++;
        }
        /// <summary>
        /// Instantiate a new Timer and runs it
        /// </summary>
        public void StartTimer()
        {
            tickTimer = new Timer(tickInterval);

            tickTimer.Elapsed += OnTick;
            tickTimer.AutoReset = true;
            tickTimer.Enabled = true;
        }
    }
}