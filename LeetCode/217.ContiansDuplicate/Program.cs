
using System.Collections.Immutable;

namespace ContainsDuplicate
{
  public class Solution
  {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        if (set.Count < nums.Length)
        {
                return true;
        }
        else
        {
                return false;
        }
    }
  }

  class CallSolution
  {
    static void Main(string[] args)
    {
      Solution solution = new Solution();
      solution.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);
    }
  }
}