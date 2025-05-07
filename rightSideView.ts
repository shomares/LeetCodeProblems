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
function rightSideView(root: TreeNode | null): number[] {
    if (root === null) {
        return []
    }

    const stack: TreeNode[] = []
    const result: number[] = []

    stack.push(root)

    while (stack.length > 0) {
        let levelSize = stack.length

        let item: TreeNode = null

        for (let index = 0; index < levelSize; index++) {
            item = stack.shift()

            if (item.left) {
                stack.push(item.left)
            }

            if (item.right) {
                stack.push(item.right)
            }

        }

        result.push(item.val)
    }

    return result
};

console.log(rightSideView(
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