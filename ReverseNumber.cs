using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void Check()
        {
        
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

            while (n != 0)
            {
                int rem = n % 10;

                rev = rev * 10 + rem;

                n = n / 10;

            }
            Console.WriteLine("Reversed Number: " + rev);
        }
    }
}
