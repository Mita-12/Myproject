namespace Myproject
{
    internal class sqr_cub
    {
        static void Main(string[] args)
        {
            int num = 20;
            int sqr = 0;
            int qub=0;
            for (int i = 1; i <= num; i++)
            {
                sqr = i * i;
                qub = i * i * i;
                Console.WriteLine($"{i}\t{sqr}\t{qub}" );                
            }
        }
    }
}

