using System;
namespace Application
{
    public class problem44
    {
        public int Add_Two_Numbers(int a, int b){
            return a+b;
        }

        public static void solution()
        {
            problem44 add = new problem44();
            int output = add.Add_Two_Numbers(2, 3);

            Console.WriteLine(output);
        }
    }
}
