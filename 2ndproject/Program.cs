using System.Diagnostics.CodeAnalysis;

namespace _2ndproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[]num = { 1, 2, 3 };
            //int[]num1 = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
                sum += num[i];
            }
            Console.WriteLine($"{sum}");
        }
    }
}
