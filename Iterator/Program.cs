using System;
using static System.Console;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            Iterator iterate = new Iterator();

            Pause();
        }

        private static void Header()
        {
            ForegroundColor = ConsoleColor.Green;

            WriteLine("Iterator pattern");

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
