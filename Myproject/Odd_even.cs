using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{ 
    internal class Odd_even
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even no");
            }
            else
            {
                Console.WriteLine($"{num} is odd no");
            }
        }

    }
}
