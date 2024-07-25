
using System;
namespace Application
{
    class Vehicle
    {

        public string Model = "Tata";
        public string Make = "company";
        public int Year = 1919;
        public int NumberOfDoors = 4;


        public virtual void Show()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Year: " + Year);
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }
    }

    class Car : Vehicle
    {

        public int numberofdoors = 6;
        public bool IsConvertible = true;

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Number of doors: " + NumberOfDoors);
            Console.WriteLine("Is convertible: " + IsConvertible);
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk Open");
        }

        public void CloseTrunk()
        {
            Console.WriteLine("Trunk Closed");
        }

        public Car(string Model, string make, int numberofdoors, int year)
        {
            this.Model = Model;
            this.Make = make;
            this.NumberOfDoors = numberofdoors;
            this.Year = year;
        }

        public static void solution()
        {
            Car obj = new Car("Toyato", "Hilux", 6, 1919);
            obj.Show();
            obj.CloseTrunk();
            obj.OpenTrunk();
            obj.StartEngine();
            obj.StopEngine();
            Console.WriteLine();

            Car obj1 = new Car("tata", "company", 4, 1966);
            obj1.Show();
            obj1.CloseTrunk();
            obj1.OpenTrunk();
            obj1.StartEngine();
            obj1.StopEngine();
        }
    }
}