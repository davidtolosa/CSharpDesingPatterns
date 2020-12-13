using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance;
        private static int TotalInstances;

        private Singleton() {
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine("--Exit from private constructor.");
        }

        static Singleton() {

            Console.WriteLine("-Static constructor is called.");
            Instance = new Singleton();
            TotalInstances++;
            Console.WriteLine($"-Singleton instance is created. Number of instances: {TotalInstances}");
            Console.WriteLine("Exit from static constructor");
        }

        public static Singleton GetInstance => Instance;

    }
}
