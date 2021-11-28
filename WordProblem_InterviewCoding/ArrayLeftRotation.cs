using System;

namespace WordProblem_InterviewCoding
{
    // Left Rotate arr[] of size n by d
    public static class ArrayLeftRotation
    {
        static void LeftRotateByOne(int[] arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[n - 1] = temp;
        }
        static void LeftRotate(int[] arr, int d, int n)
        {
            for(int i = 0; i < d; i++)
            {
                LeftRotateByOne(arr, n);
            }
        }

        public static void PrintArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            LeftRotate(arr, 2, 7);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
