using System;
namespace Application
{
    public class Problem13
    {
        public static void solution()
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=4; j>=4; j--)
                {
                    Console.Write("  ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }
    }
}