using LeetCode.Models;

namespace LeetCode
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var other = 0;
            ListNode head = new ListNode(0);
            ListNode cur = head;
            while (l1 != null || l2 != null)
            {
                var a = other + (l1?.val ?? 0) + (l2?.val ?? 0);
                ListNode node = new ListNode(a % 10);
                cur.next = node;
                cur = cur.next;
                other = a / 10;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (other > 0)
                cur.next = new ListNode(other);
            return head.next;
        }
        public ListNode AddTwoNumbersV2(ListNode l1, ListNode l2)
        {
            var array1 = GetValues(l1).Reverse().ToArray();
            var array2 = GetValues(l2).Reverse().ToArray();
            var list = new List<int>();
            var i = 1;
            var result = new ListNode();
            var other = 0;
            while (array1.Length - i >= 0 || array2.Length - i >= 0)
            {
                var a = other;
                if (array1.Length - i >= 0)
                {
                    a = a + array1[array1.Length - i];
                }
                if (array2.Length - i >= 0)
                {
                    a = a + array2[array2.Length - i];
                }

                list.Add(a % 10);
                other = a / 10;
                i++;
            }

            if (other > 0)
            {
                list.Add(other);
            }

            for (int j = 0; j < list.Count; j++)
            {
                result.val = list[list.Count - j - 1];
                result = new ListNode(0, result);
            }
            return result.next;
        }

        private IEnumerable<int> GetValues(ListNode listNode)
        {
            ListNode current = listNode;
            while (current != null)
            {
                yield return current.val;
                current = current.next;
            }
        }
    }
}
