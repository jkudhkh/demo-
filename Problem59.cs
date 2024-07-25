using System;
namespace Application
{
    class Animal
    {
      //  public string name;
        public void display()
        {
            Console.WriteLine("I am an animal");
         }  
    }
    //derive class of Animal
    class Problem59 : Animal
    {
        public void getName()
        {
          //  Console.WriteLine("My name is " + name);
        }
    
    
    
        public static void solution()
        {
            Problem59 obj = new Problem59();
          //  obj.name = "chinku";
            obj.display();
            obj.getName();
            Console.ReadLine();
        }
    }
}