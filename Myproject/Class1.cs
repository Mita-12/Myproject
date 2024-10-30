using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num = 5;
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }

    }
}
