using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
             //Singleton singleton1 = new Singleton();

            Singleton singleton2 = Singleton.GetInstance;

            Singleton singleton3 = Singleton.GetInstance;

            Console.Read();
        }
    }
}
