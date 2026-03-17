namespace CodeChallenges.Stack.MinStack
{
    public interface IMinStack
    {
        void Push(int value);
        void Pop();
        int? Top();
        int? GetMin();
    }
}
