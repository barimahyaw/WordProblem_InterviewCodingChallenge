namespace WordProblem_InterviewCoding
{
    public static class FibonacciNumbers
    {
        //Fiibannacci Series using Recursion 
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
