using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int subtract(int x, int y)
        {
            return x - y;
        }
        
        static int add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");

            var z = subtract(2, 3);
        }
    }
}
