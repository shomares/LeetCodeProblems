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

let hashmap = new Map<number, number>()
let result = 0


const pathSumRec = (root: TreeNode | null, prefixArray: number[], k: number) => {
    if (root === null) {
        return
    }

    const sumPrefix = prefixArray[prefixArray.length - 1] + root.val
    prefixArray.push(sumPrefix)
   
    if (hashmap.has(sumPrefix - k)) {
        result += hashmap.get(sumPrefix - k)
    }

    hashmap.set(sumPrefix, (hashmap.get(sumPrefix) ?? 0) + 1)
    pathSumRec(root.left, prefixArray, k)
    pathSumRec(root.right, prefixArray, k)

    hashmap.set(sumPrefix, hashmap.get(sumPrefix) - 1)

    if (hashmap.has(sumPrefix) && hashmap.get(sumPrefix) === 0) {
        hashmap.delete(sumPrefix)
    }

    prefixArray.pop()


}




function pathSum(root: TreeNode | null, targetSum: number): number {
    result = 0
    hashmap = new Map<number, number>()
    hashmap.set(0, 1)
    pathSumRec(root, [0], targetSum)
    return result
};

console.log(pathSum(new TreeNode(
    1


), 0))