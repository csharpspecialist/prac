using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 1;

            while(counter <=10)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
