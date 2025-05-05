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

enum Direction { LEFT = 0, RIGTH = 1 }

let maxLength = 0

const longestZigZagRecursive = (root: TreeNode | null, currentDirection: Direction, steps: number) => {
    if (root === null) {
        return
    }

    maxLength = Math.max(maxLength, steps)

    if (currentDirection === Direction.LEFT) {
        longestZigZagRecursive(root.right, Direction.RIGTH, steps + 1)
        longestZigZagRecursive(root.left, Direction.LEFT, 1)
    } else {
        longestZigZagRecursive(root.left, Direction.LEFT, steps + 1)
        longestZigZagRecursive(root.right, Direction.RIGTH, 1)
    }



}

function longestZigZag(root: TreeNode | null): number {
    maxLength = 0
    longestZigZagRecursive(root, Direction.LEFT, 0)
    longestZigZagRecursive(root, Direction.RIGTH, 0)
    return maxLength
};

const t1 =  new TreeNode(
    1,
    null,
    new TreeNode(
        1,
        new TreeNode(1),
        new TreeNode(
            1,
            new TreeNode(
                1,
                null,
                new TreeNode(
                    1,
                    null, 
                    new TreeNode(1)
                )


            ),
            new TreeNode(1)
        )
    )

)

const t2 = new TreeNode(
    1,
    new TreeNode(
        1, 
        null,
        new TreeNode(
            1,
            new TreeNode(
                1,
                null,
                new TreeNode(1)
            ),
            new TreeNode(1)
        )
    ),
    new TreeNode(1)
)



console.log(longestZigZag(t1))
 