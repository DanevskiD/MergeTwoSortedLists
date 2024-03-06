﻿ // Definition for singly-linked list. 
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode sortedHead = new ListNode();
        ListNode sorted = new ListNode();

        if (list1 == null && list2 == null) return null;
        else if (list1 == null || list2 == null)
        {
            if (list1 == null) return list2;
            return list1;
        }
        if (list1.val <= list2.val)
        {
            sortedHead.val = list1.val;
            list1 = list1.next;
        }
        else
        {
            sortedHead.val = list2.val;
            list2 = list2.next;
        }

        sorted = sortedHead;

        while(!(list1==null&&list2==null))
        {
            sorted.next = new ListNode();
            if(list2 == null || list1 != null && list1.val<=list2.val)
            {
                sorted.next.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                sorted.next.val = list2.val;
                list2 = list2.next;
            }

            sorted = sorted.next;
        }
        return sortedHead;
    }
}
