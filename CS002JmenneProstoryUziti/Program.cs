using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS002JmenneProstoryUziti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karel");
            Console.ReadKey();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Hofman");
            Console.ReadKey();
        }
    }
}