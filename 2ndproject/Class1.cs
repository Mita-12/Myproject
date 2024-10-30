using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndproject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the value");
            num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is a even no");
            }
            else 
            {
                Console.WriteLine($"{num} is a odd no");
            }
        }
    }
}
