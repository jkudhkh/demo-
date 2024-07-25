using System;
namespace Application
{
    public class Problem32
    {
        public static void solution()
        {
            //Using String.join(String.String[])
            int[] inputArray = {89, 78, 34, 76,34, 21};

            String sep = ";";
            string finalresult = "int: ";

            finalresult +=String.Join(sep, inputArray);
            Console.WriteLine($"Result:{finalresult}");
        }
    }
}