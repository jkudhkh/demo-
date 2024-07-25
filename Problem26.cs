using System;
namespace Application
{
    public class problem26
    {
        public static void solution()
        {
             int[] numbers = {1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12};


            foreach(int number in numbers ) 
            {
                if(number==8)
                {
                    break;
                }
                Console.WriteLine(number);
            }
        }
    }
}