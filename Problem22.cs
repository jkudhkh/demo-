using System;
namespace Application
{
    public class Problem22
    {
        public static void solution()
        {
            int[] number = {30,20,41,99};
        
            float sum = number.Sum();

            int count = number.Count();

            float average = sum/count;

            Console.WriteLine("Average : " + average);

            Console.WriteLine("Average using Average() : " + number.Average());
                
                Console.ReadLine( );
        }
    }
}

