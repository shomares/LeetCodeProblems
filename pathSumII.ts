/**
 * Definition for a binary tree node.
 * */
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

const result: number[][] = []

const pathSumIIRecursive = (root: TreeNode | null, currSum: number, sumArray: number[], targetSum: number) => {

    if (root === null) {
        return
    }

    if (root.left === null && root.right === null) {
        sumArray.push(root.val)
        const curr = currSum + root.val
        if (curr === targetSum) {
            result.push([...sumArray])
        }

        return
    }

    sumArray.push(root.val)


    pathSumIIRecursive(root.left, currSum + root.val, sumArray, targetSum)

    if (sumArray.length > 1) {
        sumArray.pop()
    }

    pathSumIIRecursive(root.right, currSum + root.val, sumArray, targetSum)

    if (sumArray.length > 1) {
        sumArray.pop()
    }
}


function pathSum(root: TreeNode | null, targetSum: number): number[][] {
    result.length = 0
    pathSumIIRecursive(root, 0, [], targetSum)
    return result
};


console.log(pathSum(new TreeNode(
    1,
    null,
    new TreeNode(
        2,
        null,
        new TreeNode(
            3,
            null,
            new TreeNode(
                4,
                null,
                new TreeNode(5)
            )

        )

    )

), 22))