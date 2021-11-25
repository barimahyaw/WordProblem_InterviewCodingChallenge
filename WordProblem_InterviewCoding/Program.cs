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
        }
    }
}
