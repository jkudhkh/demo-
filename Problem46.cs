using System;
namespace Application
{
    public class problem46
    {
        public bool  True_False(int a)  
        {
            
             if (a%2==0){
                return true;
             }
             else 
             {
                return false;
             }
        }
 
        public static void solution()
        {
           problem46 obj = new  problem46();
           bool ans = obj.True_False(70);
           Console.WriteLine(ans);
         }
        
        

    }
}