using LeetCode;


//var result = NNodes.RemoveNthFromEnd(new ListNode(1,new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);


var result = TildClass.FindTilt(
        new TreeNode
        {
            val = 4,
            left = new TreeNode
            {
                val = 2,
                left = new TreeNode(3),
                right = new TreeNode(5)
            },
            right = new TreeNode
            {
                val = 9,
                right = new TreeNode(7)
            }
        }
    );

Console.WriteLine( result );