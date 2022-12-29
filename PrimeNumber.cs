using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Check()
        {
            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int p = 0;
            for (int i = 2; i <=number/2 ; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
               Console.WriteLine("Number is Prime.");
            }
        }
    }
}
