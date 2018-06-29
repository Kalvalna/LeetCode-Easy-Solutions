/*  
    Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.

    Note that an empty string is also considered valid

    Example 1:

    Input: "()"
    Output: true

    Example 2:

    Input: "()[]{}"
    Output: true

    Example 3:

    Input: "(]"
    Output: false

    Example 4:

    Input: "([)]"
    Output: false

    Example 5:

    Input: "{[]}"
    Output: true

*/

class ValidPar
{
    // Uses stack operations to test for validity
    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                char top = stack.Pop();
                if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }
        return (stack.Count == 0) ? true : false;
    }
}