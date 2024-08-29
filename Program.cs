using LeetCode;


//var result = NNodes.RemoveNthFromEnd(new ListNode(1,new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);


var result = MergeBinaryTree.MergeTrees(new TreeNode
{
    val = 1,
    left = new TreeNode
    {
        val = 3,
        left = new TreeNode(5)
    },
    right = new TreeNode(2)

}, new TreeNode { 
    val = 2,
    left = new TreeNode
    {
        val = 1,
        right = new TreeNode(4)
    },
    right = new TreeNode { 
            val = 3,
            right = new TreeNode(7)
    }

});
Console.WriteLine(result);