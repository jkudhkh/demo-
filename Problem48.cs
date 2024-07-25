using System;
namespace Application
{
    class Problem48
    {
public int arr (int[] arr)
    {
        int largest= arr[0]; 
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }
        return largest;
    }
    public static void solution()
    {
        Problem48 ee = new Problem48();
        int[] arr = {100, 10000,1000000,10};
        int largest = ee.arr(arr);
        Console.WriteLine(largest); 
    }
    }
}

