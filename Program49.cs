using System;
namespace Application
{
    class Problem49
    {
        public int arr(int []arr)
        {
            int Length= arr[0];
            for(int i = 1; 1 < arr.Length; i++)
            {
                if (arr[i] < Length)
                {
                    Length = arr[i];
                }
            }
            return Length;
        }
        public static void solution()
        {
            Problem49 ee = new Problem49();
            int []arr ={2,4,6,8,12};
            int Length = ee.arr(arr);
            Console.WriteLine(Length);
        }
    }


}
