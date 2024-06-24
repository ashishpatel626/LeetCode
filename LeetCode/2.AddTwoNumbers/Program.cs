using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
  }

  public class Solution
  {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

      ListNode listNode = new ListNode();
      listNode.next = l2;
      return listNode;
    }
  }

  class CallSolution
  {
    public static void Main(string[] args)
    {
      Solution Solution = new Solution();
      ListNode l1 = new ListNode();
      ListNode l2 = new ListNode();

      Solution.AddTwoNumbers();
    }
  }
}