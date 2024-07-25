using System;
namespace Application
{
    public class Problem31
    {
        public static void solution()
        {
            //String Concat method 
            string String1 = "Coding";
            string String2 = "Ninjas";
            
            string finalString = String . Concat(String1, String2);
            Console.WriteLine(finalString);

            //Concatinate Concat 
            string doubleConcat = string . Concat(string.Concat (String1, String2), "Company");

            Console.WriteLine(doubleConcat);
        }
    }

}