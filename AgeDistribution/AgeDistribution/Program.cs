using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDistribution
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your current age??");
            string userAge = Console.ReadLine();


            int age = int.Parse(userAge);

        
            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("You are still in Mama's arms");
            }
            else if (age >= 3 && age <=4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High Schooler..since you think you know everything...move out!!!");
            }
            else if (age > 19 && age <= 22)
            {
                Console.WriteLine("College Years");
            }
            else if (age > 23 && age <= 65)
            {
                Console.WriteLine("Working for the man...hopefully saving for your nest egg!!");
            }
            else if (age > 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else 
            {
                Console.WriteLine("This program is for humans");
            }

            Console.ReadKey();




        }
    }
}
