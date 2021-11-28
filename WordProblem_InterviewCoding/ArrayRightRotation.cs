using System;

namespace WordProblem_InterviewCoding
{
    // Reversal algorithm for right rotation of an array by a pivot
    public static class ArrayRightRotation
    {
        // Function to reverse arr[] from index start to end
        private static void ReverseArray(int [] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        // function to right rotate arr[] of size n by d
        public static void RightRotate(int [] arr, int d, int n)
        {
            ReverseArray(arr, 0, n - 1);
            ReverseArray(arr, 0, d - 1);
            ReverseArray(arr, d, n - 1);
        }

        public static void PrintArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = arr.Length;
            int k = 3;

            RightRotate(arr, k, n);

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
