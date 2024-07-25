using System;
namespace Application
{
    public class Problem17
    {
        public static void solution()
        {
            int [] arr=[5,6,7,1];
            int smallest=arr[0];
            int length=arr.Length;
            {
                for( int i=1; i<arr.Length; i++)
                {
                    if(arr[i]<smallest)
                    {
                        smallest=arr[i];
                    }
                }
                Console.WriteLine(smallest);
            }
        }
    }
}