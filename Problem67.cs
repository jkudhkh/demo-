using System;
namespace Application
{
    class Problem67
    {
        public static void solution()
        {

            Dog myDog = new Dog();
            myDog.makesSound();
            Cat myCat = new Cat();
            myCat.makesSound();

        }

        class Animal
        {
            public void makesSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public new void makesSound()
            {
                Console.WriteLine("The dog says: bark bark");
            }
        }
        class Cat : Animal
        {
            public new void makesSound()
            {
                Console.WriteLine("The cat says: meow meow");
            }
        }


    }

}