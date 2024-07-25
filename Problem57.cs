using System;
namespace Application
{
    public class Problem57
    {
        public  string color="transparent";
         


         public Problem57 ()
         {
            
         }
       public   void showcolor()
         {
            Console.WriteLine(color);
         }
         public Problem57 (string color)
         {
            
            this.color=color;
         }
         public static void solution()
         {
            Problem57 obj=new Problem57();
            obj.showcolor();
            Problem57 bou=new Problem57("Blue");
            bou.showcolor();
         }
    }
}