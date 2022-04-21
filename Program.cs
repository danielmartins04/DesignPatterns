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
            Console.WriteLine("3 - Abstract Factory");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Structural Patterns:");
            Console.WriteLine("4 - Adapter");

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
                    FactoryMethodExecution.Execute();
                    break;
                case '3':
                    AbstractFactoryExecution.Execute();
                    break;
                case '4':
                    AdapterExecution.Execute();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
