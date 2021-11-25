using System;

namespace WordProblem_InterviewCoding
{
    public static class PermutationCoeficient
    {
        //Time Complexity is O(n*k) and space complexity is O(n*k) as the program uses as auxiliary matrix
        //to store the result
        public static int PermutationCoefficientDynamicProgrammmingBasedSolution(int n, int k)
        {
            int[,] P = new int[n + 2, k + 2];

            // Calculate value Permutation Coefficient in bottom up Manner
            for(int i = 0; i <= n; i++)
            {
                for(int j=0; j <= Math.Min(i, k); j++)
                {
                    // Base Cases
                    if (j == 0)
                        P[i, j] = 1;

                    //Calculate value using previously stored number
                    else
                        P[i, j] = P[i - 1, j] + (j * P[i - 1, j - 1]);

                    // This step is important
                    // as P[i,j]=0 for j>1
                    P[i, j + 1] = 0;
                }
            }
            return P[n, k];
        }

        // A O(n) solution that uses table fact[] to calculate the Permutation Coefficient
        public static int PermutationCoeff(int n, int k)
        {
            int[] fact = new int[n + 1];

            // base case
            fact[0] = 1;

            // Calculate value 
            // factorials up to n
            for(int i = 1; i <= n; i++)
            {
                fact[i] = i * fact[i - 1];
            }

            // P[n.k] = n! / (n - k)!
            return fact[n] / fact[n - k];
        }

        // A O(n) time and o(1) extra space solutions
        public static int PermutationCoeffExtraSpace(int n, int k)
        {
            int Fn = 1, Fk = 1;
            // Compute n! and (n-k)!
            for(int i = 1; i <= n; i++)
            {
                Fn *= i;
                if (i == n - k)
                    Fk = Fn;
            }
            int coeff = Fn / Fk;
            return coeff;
        }
    }
}
