namespace WordProblem_InterviewCoding
{
    /*
     Input  : n = 2
     Output : 1

     Input  : n = 9
     Output : 34
     */
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
