using System;
namespace Application
{
    public class Problem29
    {
        public static void solution()
        {
            //string interpolation
            string City = "Mumbai";
            string Country = "India";

            //use string interpolation to concatenate strings.
            string cityOfcountry =$"{City} is a city in {Country}.";
            Console.WriteLine(cityOfcountry);
        }
    }
}