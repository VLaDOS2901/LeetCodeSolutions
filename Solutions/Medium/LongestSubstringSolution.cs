using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    public class LongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            /*string longestSeq = "", currentSeq = "";
            Dictionary<char, int> lastSeen = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (!currentSeq.Contains(s[i]))
                {
                    currentSeq += s[i];
                    lastSeen[s[i]] = i;
                    if (currentSeq.Length > longestSeq.Length)
                        longestSeq = currentSeq;
                }
                else
                {
                    if (currentSeq.Length > longestSeq.Length)
                        longestSeq = currentSeq;
                    currentSeq = s[lastSeen[s[i]]+1].ToString();
                    i = lastSeen[s[i]] + 1;
                    lastSeen[s[i]] = i;

                }
            }

            return longestSeq.Length;*/

            int left = 0;
            int[] lastSeen = new int[128];
            int max = 0;
            for (int right = 0; right < s.Length; right++)
            {
                char current = s[right];
                if (lastSeen[current] > left)
                {
                    left = lastSeen[current];
                }

                lastSeen[current] = right + 1;

                int currentWindow = right - left + 1;
                if (currentWindow > max)
                {
                    max = currentWindow;
                }

            }
            return max;
        }
    }
}
