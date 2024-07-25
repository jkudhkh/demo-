using System;
namespace solution
{
    public class problem45
    {
        public int birth(int a, int b)
        {
          int age = a-b;
          return age; 
        }
         public static void solution()
         { 

            problem45 obj = new problem45();
            int ans = obj.birth(2024, 2000);
            Console.WriteLine(ans);
         }        
        
    }
}