using System;

namespace WordProblem_InterviewCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci Series

            Console.WriteLine(FibonacciNumbers.Fib(9));

            Console.WriteLine(".................................");

            //nth catalan number
            for (int i = 0; i < 10; i++)
                Console.WriteLine(CatalanNumber.Calalan(i));

            Console.WriteLine(".................................");

            //n'th bell number
            for (int n = 0; n < 5; n++)
                Console.WriteLine($"Bell Number of {n} is {BellNumbers.BellNumber(n)}");
        }
    }
}
