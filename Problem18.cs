using System;
namespace Application
{
    public class Problem18
    {
        public static void solution()
        {
            int [] arr=[5,6,7,1];
            int largest=arr[0];
            int length=arr.Length;
            {
                for(int i=1; i<arr.Length; i++)
                {
                    if(arr[i]>largest)
                    {
                        largest=arr[i];
                    }
                }
                Console.WriteLine(largest);
            }
        }
    }
}