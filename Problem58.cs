using System;
namespace Application
{
    class Problem58
    {
        public string model;
        //create a class constructor with a parameter 
        public Problem58(string modelName)
        {
            model = modelName;
        }

        public static void solution()
        {
            Problem58 obj = new Problem58("Mustang");
            Console.WriteLine(obj.model);
        }
    }
}      