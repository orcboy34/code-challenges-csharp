namespace CodeChallenges.ArraysAndHashing.GroupAnagrams
{
    internal class FrequencyAnagramGrouper : IAnagramGrouper
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
                var array = new int[26];
                for (int i = 0; i < str.Length; i++)
                {
                    array[str[i] - 'a']++;
                }
                var key = string.Join(",", array);

                if (map.TryGetValue(key, out List<string>? value))
                    value.Add(str);
                else
                    map[key] = [str];
            }
            return [.. map.Values];
        }
    }
}
