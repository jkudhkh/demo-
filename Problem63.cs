// using System;
// namespace Application
// {
//     class Vehicle
//     {
//         public string Model = "Tata";
//         public string Make = "company";
//         public int Year = 1919;
//         public void show()
//         {
//             Console.WriteLine("Model:" + Model);
//             Console.WriteLine("Make:" + Make);
//             Console.WriteLine("Year:" + Year);
//         }


//         public void StartEngine()
//         {
//             Console.WriteLine("Engine Started");
//         }

//         public void StopeEngine()
//         {
//             Console.WriteLine("Engine Stopped");
//         }

//     }

//     class Car : Vehicle
//     {
//         public int numberofdoors = 4;
//         public bool Isconvertible = true;
//         public new void show()
//         {
//             base.show();
//             Console.WriteLine(" numberofdoors:" + numberofdoors);
//             Console.WriteLine("Isconvertible:" + Isconvertible);

//         }
//         public void OpenTrunk()
//         {
//             Console.WriteLine("Trunk Open");
//         }

//         public void CloseTrunk()
//         {
//             Console.WriteLine("Trunk Closed");
//         }
//     }
// }
