﻿using System.Collections.Generic;

namespace Main
{
    public partial class Solution
    {
        //给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
        //如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
        //您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
        //示例：
        //输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
        //    输出：7 -> 0 -> 8
        //原因：342 + 465 = 807
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = p?.val ?? 0;
                int y = q?.val ?? 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                p = p?.next;
                q = q?.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
