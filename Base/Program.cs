using System;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestAbstract abs = new TestAbstract();
            VirtualClass vc = new VirtualClass();
            vc.Test();

            Console.ReadKey();
        }
    }
}
