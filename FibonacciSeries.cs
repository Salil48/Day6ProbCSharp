using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Check()
        {

            Console.WriteLine("Enter the number of elements: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.Write(n1 + " ");
            Console.Write(n2 + " ");

            for (int i = 2; i < num; i++) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }


        }
    }
}
