using LeetCode;


//var result = NNodes.RemoveNthFromEnd(new ListNode(1,new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
var c = new FloodFillClass();
var result = c.FloodFill([[0, 0, 0], [0, 0, 0]], 0, 0, 0);

Console.WriteLine(result);
