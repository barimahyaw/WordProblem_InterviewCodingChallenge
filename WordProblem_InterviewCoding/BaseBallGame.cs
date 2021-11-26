using System.Collections.Generic;
using System.Linq;

namespace WordProblem_InterviewCoding
{
    public class BaseBallGame
    {
        public static int StackSolution(string[] ops)
        {
            var stack = new Stack<int>();
            foreach(var op in ops)
            {
                if (op.Equals("+"))
                {
                    var top = stack.Pop();
                    var newTop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newTop);
                }
                else if (op.Equals("D"))
                {
                    stack.Push(2 * stack.Peek());
                }
                else if (op.Equals("C"))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(int.Parse(op));
                }
            }

            return stack.Sum();
        }
    }
}
