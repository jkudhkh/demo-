using System;
namespace Application
{
    public class Problem53
    {
        public double momo ( int m, float r)
        {
            double I = m * Math.Pow(r ,2);
            return I;

        }
        public static void solution()
        {
            Problem53 obj = new Problem53();
           double ans= obj.momo( 80, 7.7f);
            Console.WriteLine(ans);
        }
    }
}