using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                int searching = target - current;
                if (dict.ContainsKey(searching))
                {
                    Console.WriteLine(i + " " + dict[searching]);
                    return [i, dict[searching]];
                }
                dict[current] = i;
            }
            return Array.Empty<int>();
        }
    }
}
