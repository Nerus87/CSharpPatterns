using System;
using System.Collections.Generic;
using static System.Console;

namespace Patterns
{
    interface IObserver { void Update(int id, string message); }

    interface IObservable
    {
        void Register(IObserver observer);

        void Unregister(IObserver observer);

        void Inform(string message, IObserver observer);

        void InformAll(string message);
    }

    class Observed : IObservable
    {
        static int counter = 0;

        List<IObserver> Observers = new List<IObserver>();

        public int ID { get; private set; }

        public Observed() { ID = ++counter; }

        public void Inform(string message, IObserver observer) => observer.Update(ID, message);

        public void InformAll(string message)
        {
            if (Observers.Count > 0)
                foreach (IObserver observer in Observers)
                    observer.Update(ID, message);
        }

        public void Register(IObserver observer)
        {
            if(!Observers.Contains(observer))
            {
                Observers.Add(observer);

                observer.Update(ID, $"Observer {Observers.IndexOf(observer)} added...");
            }
        }

        public void Unregister(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                observer.Update(ID, $"Observer {Observers.IndexOf(observer)} unregistering...");

                Observers.Remove(observer);
            }
        }

        public void UnregisterAll()
        {
            if (Observers.Count > 0)
                for (int number = 0; number < Observers.Count; number++)
                    Unregister(Observers[number]);
        }

        ~Observed()
        {
            UnregisterAll();
        }
    }

    class Observer : IObserver
    {
        private static int counter = 0;

        public int ID { get; private set; } = 0;

        public Observer() { ID = ++counter; }

        public void Update(int id, string message) => WriteLine($"Observer #{ID} received message: '{message}' from Observed {id}");
    }
}
