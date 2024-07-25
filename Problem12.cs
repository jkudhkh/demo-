using System;
namespace Application
{
    public class Program12s
    {
        public static void solution()
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=3; j++)
                {
                    Console.Write("  ");
                }
                for(int k=1; k<=3; k++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }
    }
}