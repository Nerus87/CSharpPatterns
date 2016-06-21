using System;
using static System.Console;
using Wzorce.Behavioral;  

namespace Wzorce
{
    class Program
    {
        static void Main(string[] args)
        {
            new Iterator();

            new MediatorTest();

            new TestObserver();

            new TestStratgy();

            Pause();
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
