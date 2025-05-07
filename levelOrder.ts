class TreeNode {
    val: number
    left: TreeNode | null
    right: TreeNode | null
    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
        this.val = (val === undefined ? 0 : val)
        this.left = (left === undefined ? null : left)
        this.right = (right === undefined ? null : right)
    }
}


function levelOrder(root: TreeNode | null): number[][] {
    if(root === null){
        return []
    }
    const result: number[][] = []
    const queque: TreeNode[] = []

    queque.push(root)
   
    let row: TreeNode[] = []

    while(queque.length> 0){
        while (queque.length > 0) {
            row.push(queque.pop())
        }

        const rowToAdd: number[] = []
    
        while (row.length > 0) {
            const item = row.pop()
            rowToAdd.push(item.val)

            if (item.left) {
                queque.push(item.left)
            }

            if (item.right) {
                queque.push(item.right)
            }
    
          
        }

        result.push(rowToAdd)
    }
    
    return result
};


console.log(levelOrder(
    new TreeNode(3,
        new TreeNode(9,
            new TreeNode(1),
            new TreeNode(2)
        ),
        new TreeNode(20,
            new TreeNode(15),
            new TreeNode(7)

        )

    )
))