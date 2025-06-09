public class Problem1
{
    public int LongestPalindrome(string[] words)
    {
        Dictionary<string, int> map = new Dictionary<string, int>();
        int length = 0;
        bool hasMiddle = false;

        foreach (var word in words)
        {
            string reversed = new string(new char[] { word[1], word[0] });

            if (map.ContainsKey(reversed) && map[reversed] > 0)
            {
                length += 4;

                map[reversed]--;
            }

            else
            {
                if (!map.ContainsKey(word))
                    map[word] = 0;

                map[word]++;
            }
        }

        foreach (var kvp in map)
        {
            if (kvp.Key[0] == kvp.Key[1] && kvp.Value > 0)
            {
                length += 2;
                break;
            }
        }

        return length;
    }
}
