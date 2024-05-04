class ListNode(object):
     def __init__(self, val=0, next=None):
         self.val = val
         self.next = next

class Solution(object):
    def mergeKLists(self, lists):
        """
        :type lists: List[ListNode]
        :rtype: ListNode
        """
        sorted_list = []

        for head in lists:
            while head:
                sorted_list.append(head.val)
                head = head.next

        sorted_list = sorted(sorted_list)
        dummy = ListNode(0)
        current = dummy

        for value in sorted_list:
            current.next = ListNode(value)
            current = current.next

        return dummy.next
        