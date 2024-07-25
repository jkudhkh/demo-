using System;
namespace Application
{
    class Problem52
    {
        public bool dew(int i)
        {
            if (i% 4==0)
            {
                return true;

            }
            else 
            {
                return false;
            }
        }

        public static void solution()
        {
            Problem52 obj = new Problem52();
            bool ans = obj.dew(2024);
            Console.WriteLine(ans);
        }
    }
}