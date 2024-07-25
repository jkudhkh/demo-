using System;
namespace Application
{
class Problem50
{
    public float NASA(int f)
    {
        float c = (f - 32) / 1.8f;
        return c;

    }

    public static void solution()
    {
        Problem50 obj = new Problem50();
        float ans = obj.NASA(50);
        Console.WriteLine(ans);
    }
}
}
 