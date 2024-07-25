using System;
namespace Application
{
    public class Problem55
    {
        public double Calculate ( double m, double v)
        {
            double KE = 0.5 * m * v *v;
            return KE;
        }
        public static void solution()

        {
            Problem55 obj = new Problem55();
            double ans = obj.Calculate ( 8 ,7);
            Console.WriteLine(ans);
        }
    }
}