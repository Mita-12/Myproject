﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    internal class Class2
    {
        public  Class2() 
        {
            for (int i = 0; i < 10; i++)

            {
                for (int j = 0; j < i + 1; j++)
                {
                    j++;
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
        }
    
        static void Main(string[] args) 
        {
            Class2 class2 = new Class2();   
            class2.Equals(class2);  

        }
    }
}
