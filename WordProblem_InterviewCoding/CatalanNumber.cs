namespace WordProblem_InterviewCoding
{
    public static class CatalanNumber
    {
        //A recursive function to find 
        //nth catalan number

        //The first few Catalan numbers for n = 0, 1, 2, 3, … are 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, …  
        public static int Calalan(int n)
        {
            int res = 0;

            //Base case
            if (n <= 1) return 1;

            for(int i = 0; i < n; i++)
            {
                res += Calalan(i) * Calalan(n - i - 1);
            }

            return res;
        }
    }
}
