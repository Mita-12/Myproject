using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operator (+,-,*,/,%):");
            char operatorSymbol = Console.ReadLine();
            Console.WriteLine("Enter the 1st  number");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            double num2=Convert.ToDouble(Console.ReadLine());
            double result;

           switch (operatorSymbol) 

            {
                case '+':
                    result=num1 + num2; 
                    break;
                case '-':
                    result=num1 - num2;
                    break;
                case '*':
                    result=num1 * num2;
                    break;
                case '/':
                    result=num1 / num2;
                    break;
                case '%':
                    result=num1 % num2;
                    break;
                default:
                   Console.WriteLine("invalid oprater");
                    
            }


        }
    }
}
