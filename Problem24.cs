using System;
namespace Application
{
    public class problem24
    {
        public static void solution()
        {
            int[] numbers = {1, 2, 3, 4, 5};


            foreach(int number in numbers ) 
            {
                if(number==3)
                {
                    continue;
                }
                Console.WriteLine(number);
            }
        }
    }
}