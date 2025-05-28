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


function deleteNode(root: TreeNode | null, key: number): TreeNode | null {
    if (root === null) {
        return root
    }

    if (key < root.val) {
        root.left = deleteNode(root.left, key)
    }
    else if (key > root.val) {
        root.right = deleteNode(root.right, key)
    } else {

        if (root.left === null && root.right === null) {
            return null
        } else if (root.left !== null && root.right == null) {
            return root.left
        }
        else if (root.left === null && root.right !== null) {
            return root.right
        } else {

            //Find to left, its the left value
            let current = root.right

            while (current.left != null) {
                current = current.left
            }

            //I get the current left value
            root.val = current.val

            root.right = deleteNode(root.right, current.val)

        }
    }
    return root
};


var s =  new TreeNode(
            5,
            new TreeNode(
                3,
                new TreeNode(2),
                new TreeNode(4)
            ),
            new TreeNode(
                6,
                null,
                new TreeNode(7)
            )
        )

const result = deleteNode(s, 3)
console.log(result)