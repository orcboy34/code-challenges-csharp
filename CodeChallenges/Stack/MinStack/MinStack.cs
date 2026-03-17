namespace CodeChallenges.Stack.MinStack
{
    internal class MinStack : IMinStack
    {
        private readonly Stack<(int, int)> _stack = [];

        public int? GetMin()
        {
            return _stack.TryPeek(out var top) ? top.Item2 : null;
        }

        public void Pop()
        {
            _ = _stack.Pop();
        }

        public void Push(int value)
        {
            var currentMin = GetMin() ?? value;
            _stack.Push((value, Math.Min(currentMin, value)));
        }

        public int? Top()
        {
            return _stack.TryPeek(out var top) ? top.Item1 : null;
        }
    }
}
