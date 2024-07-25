using System;
namespace Application
{
    class problem51
    {
        public double Calculate (double G, double m1, double m2, double r)
        {
            double F = G *(m1 * m2)/Math.Pow(r,2);
            return F;
        }
        public static void solution()
        {
            problem51 obj = new problem51();
            double ans = obj.Calculate(6.67*Math.Pow(10,-11), 5, 6, 7);
            Console.WriteLine(ans);

        }
    }
}