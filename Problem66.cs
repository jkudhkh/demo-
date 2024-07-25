// using System;
// namespace Application
// {
//     abstract class Shape
//     {
//         public  float calculateArea();




//         public float calculatePerimeter()
//         {
//             return 0;
//         }
//     }

//     class Tringle : Shape
//     {
//         float Base;
//         float Hight;

//         public Tringle(float Base, float Hight)
//         {
//             this.Base = Base;
//             this.Hight = Hight;
//         }


//         public new  float calculateArea()
//         {
//             float area = (1 / 2.0f) * Base * Hight;
//             return area;
//         }

//         public new float calculatePerimeter()
//         {

//             return 4 * Hight;
//         }
//     }

//     class Square : Shape
//     {
//         // length of  one side square
//         float length;
//         public Square(float length)
//         {
//             this.length = length;
//         }
//         public new float calculateArea()
//         {
//             return length * length;
//         }
//         public new float calculatePerimeter()
//         {
//             return 4 * length;
//         }
//     }

//     class Rectangle : Shape
//     {
//         float length;
//         float Base;

//         public Rectangle(float length, float Base)
//         {
//             this.length = length;
//             this.Base = Base;
//         }
//         public new float calculateArea()
//         {
//             return length * Base;
//         }
//         public new float calculatePerimeter()
//         {
//             return 2 * (length + Base);
//         }
//     }

//     class Program
//     {
//         public static void solution()
//         {
//             Tringle tringle = new Tringle(3, 4);
//             float ans = tringle.calculateArea();
//             Console.WriteLine(ans);
//             float ans1 = tringle.calculatePerimeter();
//             Console.WriteLine(ans1);

//             Square square = new Square(5);
//             float ans2 = square.calculateArea();
//             Console.WriteLine(ans2);
//             float ans3 = square.calculatePerimeter();
//             Console.WriteLine(ans3);

//             Rectangle rectangle = new Rectangle(4, 5);
//             float ans4 = rectangle.calculateArea();
//             Console.WriteLine(ans4);
//             float ans5 = rectangle.calculatePerimeter();
//             Console.WriteLine(ans5);
//         }
//     }
// }
