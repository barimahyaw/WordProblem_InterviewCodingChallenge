using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProblem_InterviewCoding
{
    public class TilingProblem
    {
        //Given a “2 x n” board and tiles of size “2 x 1”, count the number of ways to tile the given board using the 2 x 1 tiles.
        //A tile can either be placed horizontally i.e., as a 1 x 2 tile or vertically i.e., as 2 x 1 tile. 
        public static int GetNumberOfWays(int n)
        {
            // Base Case
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return GetNumberOfWays(n - 1) + GetNumberOfWays(n - 2);
        }
    }
}
