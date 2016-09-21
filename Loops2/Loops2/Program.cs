using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] places = { "Rio", "Miami", "Antartica", "Milan", "Guam", "Virgin Islands", };

            for (int i = 0; i < places.Length; i++)
            {
                Console.WriteLine(places[i]);
            }
            Console.ReadKey();
            //----------------------------------------------------------
            Console.WriteLine("give me a beginning #");
            string spark = Console.ReadLine();
            int startNumber;
            bool beginNum = int.TryParse(spark, out startNumber);

            Console.WriteLine("Give me an ending #");
            string ending = Console.ReadLine();
            //int endNum = int.Parse(ending);
            int finishNumber;
            bool endingNum = int.TryParse(ending, out finishNumber);
            if (startNumber < finishNumber)
            {
                for (int i = startNumber; i <= finishNumber; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
            else if (startNumber > finishNumber)
            {
                for (int i = startNumber; i >= finishNumber; i--)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("That does not compute!!!");
            }
            Console.ReadKey();

            int rawNum;
            Console.WriteLine("Give me a # to find a power of it");
            string firstNum = Console.ReadLine();
            bool targetNum = int.TryParse(firstNum, out rawNum);

            int expNum;
            Console.WriteLine("Give me a # to power it by");
            string powerNum = Console.ReadLine();
            bool secondNum = int.TryParse(powerNum, out expNum);
            int answer = 1;
            for (int i = 0; i < expNum; i++)
            {
                Console.WriteLine(answer *= rawNum);
            }
            Console.WriteLine("Press any Key to continue");

            Console.ReadKey();
            //----------------------------------------------------------------

            Console.WriteLine("give me a number between 1 and 20 ");
            string first = Console.ReadLine();
            int numOut;
            bool numStart = int.TryParse(first, out numOut);

            //for (int i = 0; i < 20; i++)
            //{
            //    if()
            //}


            Console.WriteLine("Press any Key to continue");

            Console.ReadKey();

            //------------------ for each loop--------------

            string[] favFood = {"Barbecue", "Grilled Chicken", "Broccoli", "Pizza", "Cherry Pie", "Milk Shakes", };

            foreach (var item in favFood)
            {
                Console.WriteLine($"This is one of my favorite foods:{item}");
            }
            Console.ReadKey();

            Console.WriteLine("Press any Key to continue");

            //------------------ nested loop--------------

            int k;
            int x;
            for (k = 1; k <= 2; k++)  //here we are counting up to 2---these will be columns
            {
                for (x = 1; x <= 4; x++) //here we are counting up to 4---these will be rows
                {
                    Console.Write(x); //columns
                }
                Console.WriteLine(); //next row
            }

            Console.ReadKey();

            Console.WriteLine("Press any Key to continue");


        }
    }
}
