using System;
using System.Collections.Generic;
using System.Linq;

namespace WordProblem_InterviewCoding
{
    //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    //The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
    public static class ValiditityOfInputString
    {
        public static bool IsValid(String s)
        {
            int length = s.Length;
            char[] array = s.ToCharArray();

            if (length == 0) return false;
            
            var stack = new Stack<char>();
            for(int i=0; i < length; i++)
            {
                if(array[i]=='(' || array[i]=='{' || array[i] == '[')
                {
                    stack.Push(array[i]);
                }
                if(array[i]==')' || array[i]=='}' || array[i] == ']')
                {
                    if (!stack.Any()) return false;
                    var temp = stack.Pop();
                    if((temp=='(' && array[i]==')') || (temp=='{' && array[i]=='}') || (temp=='[' && array[i] == ']'))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }

            if (stack.Any()) return false;
            return true;
        }
    }
}
