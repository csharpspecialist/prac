using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals1
{
    class Program
    {
        static void Main(string[] args)
        {
            int jessicaAge = 23;
            int SamAge = 47;

            Console.WriteLine(jessicaAge < SamAge );
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int sugarTotal = 7;
            int sugarNow = 2;
            int sugarLeft = sugarTotal - sugarNow;
            Console.WriteLine($"the total amount of sugar you should put in is {sugarLeft} \n Press any Key to continue");
            Console.ReadKey();

            int Mike = 13;
            int friend1 = 13;
            int friend2 = 13;
            int friend3 = 13;
            int totalBill = friend1 + friend2 + friend3 + Mike;

            Console.WriteLine($"the total bill amount is {totalBill}");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();
        }
    }
}
