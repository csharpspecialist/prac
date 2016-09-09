using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaTime
{
    class Program
    {
        static void Main()
        {

          
            for (int i = 0; i <= 100; i++)
            {
                if (IsEven(i))
                {
                    Console.WriteLine(i);
                }
              
            }
          //  Console.ReadKey();

            for (int k = 0; k < 100; k++)
            {
              
                if (isOdd(k))
                {
                    Console.WriteLine(k);
                }
            }


        }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(int start)
        {
            return start % 2 != 0;
        }



    }
}
