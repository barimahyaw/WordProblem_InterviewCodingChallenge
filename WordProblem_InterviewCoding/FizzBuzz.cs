using System;

namespace WordProblem_InterviewCoding
{
    /*When a number is multiple of three, print “Fizz” instead of a number on the console and if multiple of five then print “Buzz” on the console.
    For numbers which are multiple of three as well five, print “FizzBuzz” on the console.*/
    public static class FizzBuzz
    {
        public static void Method1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Method2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.WriteLine(str);
            }
        }
    }
}
