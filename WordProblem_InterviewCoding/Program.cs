using System;

namespace WordProblem_InterviewCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci Series
            Console.WriteLine("fibonacci number");
            Console.WriteLine(FibonacciNumbers.Fib(9));

            Console.WriteLine(".................................");

            //nth catalan number
            Console.WriteLine("catalan number");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(CatalanNumber.Calalan(i));

            Console.WriteLine(".................................");

            //n'th bell number
            Console.WriteLine("Bell Numbers");
            for (int n = 0; n < 5; n++)
                Console.WriteLine($"Bell Number of {n} is {BellNumbers.BellNumber(n)}");

            Console.WriteLine(".................................");

            //fizzbuzz
            Console.WriteLine("fizzbuzz method 1");
            FizzBuzz.Method1(15);
            Console.WriteLine(".................................");
            Console.WriteLine("fizzbuzz method 2");
            FizzBuzz.Method2(15);
        }
    }
}
