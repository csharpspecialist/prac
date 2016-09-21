using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("To the power of ?");
            int m = int.Parse(Console.ReadLine());
            int result = 1; //initialize result
            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine(result);
            Console.WriteLine("Press any Key to continue");

            Console.ReadKey();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            string[]  dude = {"new", "Car", "place", "swagger", "movie", "wonderful", "boobs", "ginger", };
            for (int d = 0; d < dude.Length; d++)
            {
                Console.WriteLine(dude[d]);
            }
            Console.ReadLine();



            //int sum = 0;
            //int counter = 1;
            //while (counter <= 10)
            //{
            //    sum += counter;
            //    counter++;
            //}
            //Console.WriteLine($"The sum of 1 - 10 is {sum}");
            //Console.WriteLine("Press any Key to continue");
            //Console.ReadLine();

            //int startNumber;
            //int finalNumber;
            //bool firstNum;
            //bool lastNum;
            //string beginNum;
            //Console.WriteLine("Choose a starting positive number to begin the loop");
            //beginNum = Console.ReadLine();
            //firstNum = int.TryParse(beginNum, out startNumber);


            //Console.WriteLine("Choose a ending positive number to begin the loop");
            //string endNum = Console.ReadLine();
            //lastNum = int.TryParse(endNum, out finalNumber);

            //while(startNumber > finalNumber && startNumber <= 0 && finalNumber <= 0)
            //{
            //    Console.WriteLine("Your starting # must be less than your ending #");
            //    beginNum = Console.ReadLine();
            //    firstNum = int.TryParse(beginNum, out startNumber);

            //    for (int i = startNumber; i < finalNumber; i++)
            //    {
            //        Console.WriteLine();
            //    }
            //}


            int looper = 0;
            int startNumber;
            Console.WriteLine("Choose a starting positive number to begin the loop");
            string beginNum = Console.ReadLine();
            bool firstNum = int.TryParse(beginNum, out startNumber);

            int finalNumber;
            Console.WriteLine("Choose a ending positive number to begin the loop");
            string endNum = Console.ReadLine();
            bool lastNum = int.TryParse(endNum, out finalNumber);


            //while (looper != finalNumber)
            //{
            //    startNumber
            //    looper++;
            //}


            int sum = 0;
            int counter = 25;
            while (sum < counter)
            {
                //sum += counter;
                sum++;
            }
            Console.WriteLine($"The sum of 1 - 10 is {sum}");
           // Console.WriteLine("Press any Key to continue");
            Console.ReadLine();



        }
    }
}
