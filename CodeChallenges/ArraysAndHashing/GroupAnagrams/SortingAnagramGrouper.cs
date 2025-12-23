
namespace CodeChallenges.ArraysAndHashing.GroupAnagrams
{
    internal class SortingAnagramGrouper : IAnagramGrouper
    {
        public List<List<string>> GroupAnagrams(string[] strings)
        {
            var result = new List<List<string>>();
            var map = new Dictionary<string, List<string>>();
            if (strings.Length == 1)
            {
                result.Add([.. strings]);
                return result;
            }
            foreach (var str in strings)
            {
                var array = str.ToCharArray();
                Array.Sort(array);
                var sorted = new string(array);
                if (map.TryGetValue(sorted, out List<string>? value))
                    value.Add(str);
                else
                    map[sorted] = [str];
            }
            return [.. map.Values];
        }
    }
}
