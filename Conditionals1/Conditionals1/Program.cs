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
            Console.WriteLine("the answer to if Jessica is younger than Sam is ");
            Console.WriteLine(jessicaAge < SamAge );
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int sugarTotal = 7;
            int sugarNow = 2;
            int sugarLeft = sugarTotal - sugarNow;
            Console.WriteLine($"the remaining # of cups of sugar you should put in is {sugarLeft} \n Press any Key to continue");
            Console.ReadKey();

            int Mike = 13;
            int friend1 = 13;
            int friend2 = 13;
            int friend3 = 13;
            int totalBill = friend1 + friend2 + friend3 + Mike;

            Console.WriteLine($"the total bill amount is {totalBill} bucks");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int totalDiapers = 40;
            int package = 8;

            Console.WriteLine($"the total # of packages of diapers that you can buy is {totalDiapers/package}");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int startCash = 29;
            int endCash = 41;

            Console.WriteLine($"Travon recieved {endCash - startCash} additional dollars");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int julia = 47;
            int pranave = julia - 30;

            Console.WriteLine($"Julia ran 30 more miles than Pranave... so Pranav ran {pranave} miles");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int money = 12;
            int boxEnvelopes = 3;

            Console.WriteLine($"I can buy {money/boxEnvelopes} boxes of envelopes.");

            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            double beginCash = 27.10;
            double salad = 5.12;
            double finalCash = beginCash - salad;

            Console.WriteLine($"Noraci started out with {beginCash} then bought a salad for {salad} \n Now Noraci has {finalCash} left.");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();






        }

 
    }
}
