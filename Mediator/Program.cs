using System;
using static System.Console;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            Mediator mediator = new Mediator();

            Instance instance_1, instance_2, instance_3;
            CreateInstances(out instance_1, out instance_2, out instance_3);

            RegisterInstances(mediator, instance_1, instance_2, instance_3);

            SendInfo(instance_1, instance_2, instance_3);

            Pause();
        }

        private static void SendInfo(Instance instance_1, Instance instance_2, Instance instance_3)
        {
            instance_1.Send(instance_2.ID, "Im first here");
            instance_2.Send(instance_3.ID, "Im second here");
            instance_3.Send(instance_1.ID, "Im third here");
        }

        private static void Header()
        {
            ForegroundColor = ConsoleColor.Green;

            WriteLine("Mediator pattern");

            ResetColor();
        }

        private static void CreateInstances(out Instance instance_1, out Instance instance_2, out Instance instance_3)
        {
            instance_1 = new Instance("first");
            instance_2 = new Instance("second");
            instance_3 = new Instance("third");
        }

        private static void RegisterInstances(Mediator mediator, Instance instance_1, Instance instance_2, Instance instance_3)
        {
            mediator.Register(instance_1);
            mediator.Register(instance_2);
            mediator.Register(instance_3);
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
