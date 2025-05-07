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

function maxLevelSum(root: TreeNode | null): number {

    if (root === null) {
        return -1
    }
    const stack: TreeNode[] = []
    let maxSum = Number.MIN_SAFE_INTEGER
    let result = 0
    let level = 0

    stack.push(root)

    while (stack.length > 0) {

        const length = stack.length

        let newSum = 0

        for (let index = 0; index < length; index++) {

            const item = stack.shift()
            newSum += item.val
            if (item.left) {
                stack.push(item.left)
            }

            if (item.right) {
                stack.push(item.right)
            }
        }

        level++

        if(newSum> maxSum){
            maxSum = newSum
            result = level
        }
    }



    return result
};

console.log(maxLevelSum(
    new TreeNode(
        -100,
        new TreeNode(
            -200,
            new TreeNode(-20),
            new TreeNode(-5)
        ),
        new TreeNode(
            -300,
            new TreeNode(-10)
        )
    )

))