using System;
using static System.Console;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            Observer observer_1, observer_2, observer_3, observer_4, observer_5;
            CreateObservers(out observer_1, out observer_2, out observer_3, out observer_4, out observer_5);

            Observed observed_1, observed_2, observed_3;
            CreateObserved(out observed_1, out observed_2, out observed_3);

            Registering(observer_1, observer_2, observer_3, observer_4, observer_5, observed_1, observed_2, observed_3);

            observed_1.UnregisterAll();

            observed_2.Unregister(observer_3);

            observed_2.InformAll("observer 3 was unregistered");

            observed_3.Unregister(observer_3);

            Pause();
        }

        private static void CreateObserved(out Observed observed_1, out Observed observed_2, out Observed observed_3)
        {
            observed_1 = new Observed();
            observed_2 = new Observed();
            observed_3 = new Observed();
        }

        private static void CreateObservers(out Observer observer_1, out Observer observer_2, out Observer observer_3, out Observer observer_4, out Observer observer_5)
        {
            observer_1 = new Observer();
            observer_2 = new Observer();
            observer_3 = new Observer();
            observer_4 = new Observer();
            observer_5 = new Observer();
        }

        private static void Registering(Observer observer_1, Observer observer_2, Observer observer_3, Observer observer_4, Observer observer_5, Observed observed_1, Observed observed_2, Observed observed_3)
        {
            observed_1.Register(observer_1);
            observed_1.Register(observer_2);
            observed_1.Register(observer_3);
            observed_1.Register(observer_4);
            observed_1.Register(observer_5);
            observed_2.Register(observer_3);
            observed_2.Register(observer_5);
            observed_3.Register(observer_2);
            observed_3.Register(observer_3);
            observed_3.Register(observer_4);
        }

        private static void Header()
        {
            ForegroundColor = ConsoleColor.Green;

            WriteLine("Observer pattern");

            ResetColor();
        }

        internal static ConsoleKeyInfo Pause(string message = "Please press ANY key to continue...")
        {
            ForegroundColor = ConsoleColor.Red;

            Write(message);

            ResetColor();

            return ReadKey();
        }
    }
}
