using System;
using static System.Console;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            Context add = new Context(new Add());

            WriteLine($"Add(1 + 2) = {add.DoCalculate(1, 2)}");

            Context sub = new Context(new Sub());

            WriteLine($"Substract(1 - 2) = {sub.DoCalculate(1, 2)}");

            Pause();
        }

        private static void Header()
        {
            ForegroundColor = ConsoleColor.Green;

            WriteLine("Strategy pattern");

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



