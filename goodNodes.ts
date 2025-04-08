/**
 * Definition for a binary tree node.
 * 
 **/

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

let countNodes: number = 0

const goodNodesRecursive = (root: TreeNode | null, maxValueNode: number | null) => {

    if (root === null) {
        return
    }

    if (maxValueNode === null) {
        countNodes++
        goodNodesRecursive(root.left, root.val)
        goodNodesRecursive(root.right, root.val)
        return
    }


    if (maxValueNode <= root.val) {
        countNodes++
    }

    const maxValue = Math.max(maxValueNode, root.val)
    goodNodesRecursive(root.left, maxValue)
    goodNodesRecursive(root.right, maxValue)



}


function goodNodes(root: TreeNode | null): number {
    countNodes = 0
    goodNodesRecursive(root, null)
    return countNodes
};


const value = goodNodes(new TreeNode(
    3,
    new TreeNode(
        1,
        new TreeNode(3)
    ),
    new TreeNode(
        4,
        new TreeNode(1),
        new TreeNode(5)
    )
))

console.log(value)