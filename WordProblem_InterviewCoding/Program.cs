using System;

namespace WordProblem_InterviewCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci Series
            Console.WriteLine("fibonacci number Output");
            Console.WriteLine(FibonacciNumbers.Fib(9));

            Console.WriteLine(".................................");

            //nth catalan number
            Console.WriteLine("catalan number output");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(CatalanNumber.Calalan(i));

            Console.WriteLine(".................................");

            //n'th bell number
            Console.WriteLine("Bell Numbers Output");
            for (int n = 0; n < 5; n++)
                Console.WriteLine($"Bell Number of {n} is {BellNumbers.BellNumber(n)}");

            Console.WriteLine(".................................");

            //fizzbuzz
            Console.WriteLine("fizzbuzz method 1 Output");
            FizzBuzz.Method1(15);
            Console.WriteLine(".................................");
            Console.WriteLine("fizzbuzz method 2 Output");
            FizzBuzz.Method2(15);

            Console.WriteLine(".................................");

            //Binomial Coefficient
            Console.WriteLine("Binomial Coefficient recursive method output");
            Console.WriteLine(BinomialCoefficients.BinomialCoeffRecursiveMethod(5, 2));
            Console.WriteLine("Binomial Coefficient Dynamic Programming method output");
            Console.WriteLine(BinomialCoefficients.BinomialCoeffDynamicProgrammingMethod(5, 2));

            Console.WriteLine(".................................");

            //Permutation Coefficient
            Console.WriteLine(PermutationCoeficient.PermutationCoefficientDynamicProgrammmingBasedSolution(10, 2));
            Console.WriteLine(PermutationCoeficient.PermutationCoeff(10, 2));
            Console.WriteLine(PermutationCoeficient.PermutationCoeffExtraSpace(10, 2));

            Console.WriteLine(".................................");

            //Tilling Problem
            Console.WriteLine(TilingProblem.GetNumberOfWays(4));

            Console.WriteLine(".................................");

            // Base Ball Game score
            string[] input = new string[] { "5", "2", "C", "D", "+" };
            Console.WriteLine(BaseBallGame.StackSolution(input));

            Console.WriteLine(".................................");

            Console.WriteLine(K_th_Character_of_Decrypted_String.EncodedChar("ab4c12ed3", 21));
        }
    }
}
