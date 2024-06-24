
using System.Collections.Immutable;

namespace ContainsDuplicate
{
  public class Solution
  {
    public bool ContainsDuplicate(int[] nums)
    {

      Array.Sort(nums);

      foreach(int i in nums)
      {
        if (i > 0)
        {

        }
      }
      
      if (true)
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