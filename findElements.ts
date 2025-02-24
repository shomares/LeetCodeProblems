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

class FindElements {
    private hashSet = new Set<number>()
    constructor(root: TreeNode | null) {
        this.hashSet.add(0)
        this.constuctTreeNodeRecursive(root, 0)
    }

    private constuctTreeNodeRecursive(root: TreeNode | null, value: number) {
        if (root == null) {
            return
        }

        if (root.left) {
            const leftValue = 2 * value + 1
            this.hashSet.add(leftValue)
            this.constuctTreeNodeRecursive(root.left, leftValue)
        }

        if (root.right) {
            const rightValue = 2 * value + 2
            this.hashSet.add(rightValue)
            this.constuctTreeNodeRecursive(root.right, rightValue)
        }
    }

    find(target: number): boolean {
        return this.hashSet.has(target)
    }
}

let findElements = new FindElements(new TreeNode(
    -1,
    new TreeNode(
        -1,
        new TreeNode(-1),
        new TreeNode(-1)
    ),
    new TreeNode(-1)
))

console.log(findElements.find(1)); // return True
console.log(findElements.find(3)); // return True
console.log(findElements.find(5)); // return False

