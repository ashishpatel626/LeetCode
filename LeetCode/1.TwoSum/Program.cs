using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
  class Solution
  {

    public int[] TwoSum(int[] nums, int target)
    {
      IDictionary<int, int> dictionary = nums.Select((value, index) => new { value, index })
                     .ToDictionary(key => key.index, value => value.value);

      IDictionary<int, int> Seen = new Dictionary<int, int>();

      List<int> result = new List<int>();

      foreach (KeyValuePair<int, int> pair in dictionary)
      {
        int diff = target - pair.Value;

        if (Seen.ContainsKey(diff))
        {
          result.Add(Seen[diff]);
          result.Add(pair.Key);
          break;
        }
        else if (!Seen.ContainsKey(pair.Value))
        {
          Seen.Add(pair.Value, pair.Key);
        }

      }
      return result.ToArray();
    }

  }

  class CallSolution
  {
    public static void Main(string[] args)
    {
      Solution Solution = new Solution();
      Solution.TwoSum([3, 3], 6);
    }
  }
}

