namespace CodeChallenges.Stack.ValidParentheses
{
    internal class ParenthesisValidator : IParenthesesValidator
    {
        private static readonly HashSet<char> _openers = ['(', '[', '{'];
        private static readonly Dictionary<char, char> _closers = new()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        public bool Validate(string input)
        {
            var stack = new Stack<char>();

            foreach (char c in input)
            {
                if (_openers.Contains(c))
                    stack.Push(c);
                else if (_closers.ContainsKey(c) && stack.TryPeek(out var top))
                {
                    if (_closers[c] != top)
                        return false;
                    _ = stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
