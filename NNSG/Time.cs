using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    class Time
    {
        private static Time instance;

        /// <summary>
        /// Return the single instance of this class
        /// </summary>
        /// <returns></returns>
        public static Time GetInstance()
        {
            if (instance == null)
            {
                instance = new Time();
            }

            return instance;
        }

        /// <summary>
        /// Defines how much time should pass between each tick
        /// 1 / [tick per second]
        /// </summary>
        const float TICK_INTERVAL = 1 / 1;

        /// <summary>
        /// Keeps track of elapsed time after last tick
        /// </summary>
        private float tick_timer;

        /// <summary>
        /// List of subscribed item that implements ITick interface
        /// </summary>
        List<ITick> subscribers = new List<ITick>();

        /// <summary>
        /// Subscribe an object that implemented ITick interface
        /// </summary>
        /// <param name="newSubscriber"></param>
        public void Subscribe(ITick newSubscriber)
        {
            if (!subscribers.Contains(newSubscriber))
                subscribers.Add(newSubscriber);
        }

        /// <summary>
        /// Unsubscribe an object that implemented ITick interface 
        /// </summary>
        /// <param name="oldSubscriber"></param>
        public void Unsubscribe(ITick oldSubscriber)
        {
            subscribers.Remove(oldSubscriber);
        }

        /// <summary>
        /// Makes the simulation advance by 1 step forward
        /// </summary>
        public void Tick()
        {
            foreach(ITick subscriber in subscribers)
            {
                subscriber.Ticking();
            }
        }
    }
}