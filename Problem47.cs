using System;
namespace Application
{
    class problem47
    {
public int arr (int[] arr)
    {
        int smallest = arr[0]; 
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
            }
        }
        return smallest;
    }
    public static void solution()
    {
        problem47 ee = new problem47();
        int[] arr = {100, 10000,1000000,10};
        int smallest = ee.arr(arr);
        Console.WriteLine(smallest); 
    }
    }
}

