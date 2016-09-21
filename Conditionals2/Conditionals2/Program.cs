using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine( );
          //  Console.ReadKey();

            double students = 324;
            double buses = 7;
            int cartravelers = 7;

            Console.WriteLine($"A Total of {students} traveled in {buses} buses while {cartravelers} students traveled in cars.\n So {students/buses} were in each bus.");
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int AliyahCash = 24;
            int pencils = 7;
            int cashleft = 10;
            int AliyahSpent = 14;

            Console.WriteLine($"Aliyah had {AliyahCash} to spend on {pencils} pencils. \n She had {cashleft} bucks left so each pencil cost {AliyahSpent/pencils} dollars");

            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();

            int[] drew = { 23, 24, 25 };


            int sum = drew.Sum();  //built in method to find the sum of an array
            Console.WriteLine($"The sum of the array elements equals {sum}");
            int mini = drew.Min(); //built in method to find the minimum value of an array
            Console.WriteLine($"The smallest # in the array is {mini}");
            Console.ReadKey();

            int[] consec3 = { 15, 16, 17 };


            int total = consec3.Sum();  //built in method to find the sum of an array
            Console.WriteLine($"The sum of the array elements equals {total}");
            int small = consec3.Min(); //built in method to find the minimum value of an array
            Console.WriteLine($"The smallest # in the array is {small}");
            Console.ReadKey();


            Console.WriteLine("Do you wish to donate???");
            string donateAns = Console.ReadLine().ToLower();

            if (donateAns == "y")
            {
                int money;
                Console.WriteLine("What's the name of the Donor");
                string donateName = Console.ReadLine();
                Console.WriteLine("How much do you wish to donate");
                string donateAmt = Console.ReadLine();
                Console.WriteLine("What's Your Address");
                string address = Console.ReadLine().ToLower();
                Console.WriteLine("What is you email address?");
                string email = Console.ReadLine();
                Console.WriteLine("Which Fiscal year is this for");
                string fiscalYear = Console.ReadLine().ToLower();

                bool bucks = int.TryParse(donateAmt, out money);
                Console.WriteLine($"Thanks for your ${money} donation...GIVE US MORE!!!");

                Console.WriteLine($"OK...The name on the receipt is { donateName}\n The amount of the donation is ${donateAmt}");
                Console.WriteLine($"The address on the receipt is { address}\n The email address is {email} \n and the the Fiscal Year is {fiscalYear}");
            }
            else
            {
                Console.WriteLine("We Hope you decide to donate at a later date");
            }

           
            Console.ReadKey();

            Console.WriteLine("Enter a # between 1 and 10");
            string numChoice = Console.ReadLine();

            switch(numChoice)
            {
                case "1":
                    Console.WriteLine($"You chose {numChoice} and the answer is 1 ");
                    break;

                case "2":
                    Console.WriteLine($"You chose {numChoice} and the answer is 2 ");
                    break;

                case "3":
                    Console.WriteLine($"You chose {numChoice} and the answer is 3 ");
                    break;

                case "4":
                    Console.WriteLine($"You chose {numChoice} and the answer is 4 ");
                    break;

                case "5":
                    Console.WriteLine($"You chose {numChoice} and the answer is 5 ");
                    break;

                case "6":
                    Console.WriteLine($"You chose {numChoice} and the answer is 6 ");
                    break;

                case "7":
                    Console.WriteLine($"You chose {numChoice} and the answer is 7 ");
                    break;

                case "8":
                    Console.WriteLine($"You chose {numChoice} and the answer is 8 ");
                    break;

                case "9":
                    Console.WriteLine($"You chose {numChoice} and the answer is 9 ");
                    break;

                case "10":
                    Console.WriteLine($"You chose {numChoice} and the answer is 10 ");
                    break;

                default:
                    Console.WriteLine("Your choice does not compute");
                    break;
            }
            Console.WriteLine(" Press any Key to continue");
            Console.ReadKey();



        }




    }
}
