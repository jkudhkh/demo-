using System;
namespace Application
{
    public class Problem14
    {
        public static void solution()
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=3; j>=i; j--)
                {
                    Console.Write("  ");
                }
                for(int l=2; l<=i; l++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
            }
        }
    }
}