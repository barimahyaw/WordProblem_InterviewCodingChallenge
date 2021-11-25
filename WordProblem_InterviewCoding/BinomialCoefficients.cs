// C# Code for Dynamic Programming |
// Set 9 (Binomial Coefficient)
using System;

namespace WordProblem_InterviewCoding
{
    //Write a function that takes two parameters n and k and returns the value of Binomial Coefficient C(n, k).
    //For example, your function should return 6 for n = 4 and k = 2, and it should return 10 for n = 5 and k = 2.
    public static class BinomialCoefficients
    {
        // Returns value of Binomial Coefficient C(n, k)
        public static int BinomialCoeffRecursiveMethod(int n, int k)
        {
            //Base Cases
            if (k > n) return 0;
            if (k == 0 || k == n) return 1;

            // Recurring
            return BinomialCoeffRecursiveMethod(n - 1, k - 1) + BinomialCoeffRecursiveMethod(n - 1, k);
        }



        // A Dynamic Programming based solution that uses table C[][] to calculate the Binomial Coefficient

        // Returns value of Binomial Coefficient C(n, k)
        public static int BinomialCoeffDynamicProgrammingMethod(int n, int k)
        {
            int[,] C = new int[n + 1, k + 1];
            int i, j;

            //Calculate value of Binomial Coefficient in bottom up manner
            for (i = 0; i <= n; i++)
            {
                //for(j=0; j <= Math.Min(i, k); j++)
                for (j = 0; j <= Min(i, k); j++)
                {
                    //Base Cases
                    if (j == 0 || j == i)
                        C[i, j] = 1;

                    //Calculate value using previously stored values
                    else
                        C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
                }
            }

            return C[n, k];
        }

        // A utility function to return minimum of two integers.
        // Use this in replace of System.Math.Min in case import (using system function) isn't allowed 
        static int Min(int a, int b) { return (a < b) ? a : b; }
    }
}
