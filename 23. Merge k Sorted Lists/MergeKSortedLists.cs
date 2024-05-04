public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var sortedList = new List<int>();

        foreach (var head in lists) {
            var currentHeadNode = head;
            while (currentHeadNode != null) {
                sortedList.Add(currentHeadNode.val);
                currentHeadNode = currentHeadNode.next;
            }
        }

        sortedList.Sort();

        var dummyNode = new ListNode(0);
        var currentNode = dummyNode;

        foreach (var value in sortedList) {
            currentNode.next = new ListNode(value);
            currentNode = currentNode.next;
        }

        return dummyNode.next;
    }
}