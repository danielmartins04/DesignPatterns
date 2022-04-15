using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select the desired option:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Creational Patterns:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Singleton");
            Console.WriteLine("2 - Factory Method");

            var option = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            switch (option.KeyChar)
            {
                case '1':
                    SingletonExecution.Execute();
                    break;
                case '2':
                    Client.Execute();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
