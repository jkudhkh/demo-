using System;
namespace Application
{
    public class Problem23
    {
        public static void solution()
        {

            int[] number = { 1, 2, 3, 4 };

            Console.WriteLine("old value at index o ; " + number [0]);

            number [0] = 11;

            Console.WriteLine("New value at index 0: " + number [0]);

            Console.ReadLine();
        }
    }
}