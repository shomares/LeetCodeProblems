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



let found = false

function createPath(root: TreeNode | null, toFind: TreeNode, array: TreeNode[]) {
    if (root === null || found === true) {
        return
    }

    array.push(root)

    if (root === toFind) {
        found = true
        return
    }

    createPath(root.left, toFind, array)
    createPath(root.right, toFind, array)

    if (!found) {
        array.pop()
    }


}

function lowestCommonAncestor(root: TreeNode | null, p: TreeNode | null, q: TreeNode | null): TreeNode | null {
    const arrayP: TreeNode[] = []
    const arrayQ: TreeNode[] = []

    found = false
    createPath(root, p, arrayP)
    found = false
    createPath(root, q, arrayQ)


    const longArray = arrayP.length >= arrayQ.length ? arrayP : arrayQ
    const smallArray = arrayP.length >= arrayQ.length ? arrayQ : arrayP

    const smallMap = new Map<number, TreeNode>()
    for (let item of smallArray) {
        smallMap.set(item.val, item)
    }

    while (longArray.length > 0) {
        const valArray = longArray.pop()

        if (smallMap.has(valArray.val)) {
            return smallMap.get(valArray.val)
        }
    }


    return root
};

function lowestCommonAncestorBest(root: TreeNode | null, p: TreeNode | null, q: TreeNode | null): TreeNode | null {
    if (root === null || root === p || root === q) {
        return root;
    }

    const left = lowestCommonAncestorBest(root.left, p, q);
    const right = lowestCommonAncestorBest(root.right, p, q);

    if (left !== null && right !== null) {
        return root;
    }

    return left !== null ? left : right;
}



const q = new TreeNode(4)

const p = new TreeNode(5,
    new TreeNode(6),
    new TreeNode(
        2,
        new TreeNode(7),
        q
    )

)

const tree = new TreeNode(
    3,
    p,
    new TreeNode(
        1,
        new TreeNode(0),
        new TreeNode(8)
    )
)

const s = lowestCommonAncestor(tree, p, q)

console.log(s)

