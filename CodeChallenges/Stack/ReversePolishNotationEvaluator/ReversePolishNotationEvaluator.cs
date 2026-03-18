namespace CodeChallenges.Stack.ReversePolishNotationEvaluator
{
    internal class ReversePolishNotationEvaluator : IReversePolishNotationEvaluator
    {
        private static readonly HashSet<string> _operands = ["+", "-", "*", "/"];
        public int Evaluate(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out var result))
                {
                    stack.Push(result);
                }
                else if (_operands.Contains(token))
                {
                    var second = stack.Pop();
                    var first = stack.Pop();
                    stack.Push(token switch
                    {
                        "+" => first + second,
                        "-" => first - second,
                        "*" => first * second,
                        "/" => first / second,
                        _ => throw new ArgumentException("Invalid operation")
                    });
                }
            }

            return stack.Pop();
        }
    }
}
