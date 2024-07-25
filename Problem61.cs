using System;
namespace Application
{
    class Problem61
    {
        public int age=17;

        public Problem61()
        {}

        public void showage()
        {
            Console.WriteLine("age:"+age);
        }

        public Problem61(int ages)
        {
            age=ages;
        }
        public void showage1()
        {
            Console.WriteLine("age:"+age);
        }
        public static void  solution()
        {
            Problem61 mama = new Problem61();
            mama.showage();
            Problem61 nana = new Problem61(18);
            nana.showage();
            
        }
    }
}