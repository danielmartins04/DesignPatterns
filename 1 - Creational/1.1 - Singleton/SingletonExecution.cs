using System;

namespace DesignPatterns
{
    public class SingletonExecution
    {
        public static void Execute()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Success, both variables contain the same instance!!!");
            }
            else
            {
                Console.WriteLine("Failed, variables contain diferent instance!!!");
            }
        }
    }
}