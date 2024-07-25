using System;
namespace Application
{
    
    public class problem41
    {
        public int Add_Two_Numbers(int a, int b){
            return a-b;
        }
        public string YourName(string firstname, string lastname){
             return $"{firstname} {lastname}";
        }
        public void Display(string firstname, string lastname){
            Console.WriteLine($"{firstname} {lastname}");
        }
        public bool True_False(){
            return true;
        }
        public static void solution()
       { 
         int []a = {4,1,9,0};
         
            // for( int i=0; i<a.Length; i++)
            // {
            //     string strFrormat = string.Format("The value of ithem at {0} is {1}", i,a[i]);
            //     Console.WriteLine(strFrormat);
            // }
            problem41 add = new problem41();
            int output = add.Add_Two_Numbers(2,3);
            int output2 = add.Add_Two_Numbers(12,3);
            string name = add.YourName("namrata","rana");
            bool something = add.True_False();
            Console.WriteLine(output);
             Console.WriteLine(output2);
              Console.WriteLine(name);
               Console.WriteLine(something);
              add.Display("namrata","rana");
          
        }
    }
}