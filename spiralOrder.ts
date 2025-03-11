let result: number[] = []

/*
Index	Direction	dy	dx
0	Right	0	1
1	Down	1	0
2	Left	0	-1
3	Up	   -1	0
*/

let x = 0
let y = 0

function spiralOrderRec(matrix: number[][], dx: number, dy: number, timesx: number, timesy: number, move: boolean) {

    if (timesx === 0 && timesy === 0) {
        return
    }

    let index = 0
    const times = move ? timesx : timesy

    while (index < times) {
        x += dx
        y += dy
        const num = matrix[y][x]
        result.push(num)
        index++
    }

    //R -> D -> L -> U

    //Right -> Down
    if (dx == 1 && dy == 0) {
        spiralOrderRec(matrix, 0, 1, timesx, timesy, false)
    }
    else if (dx == 0 && dy == 1) {
        spiralOrderRec(matrix, -1, 0, timesx, timesy, true)
    }
    else if (dx === -1 && dy === 0) {
        spiralOrderRec(matrix, 0, -1, timesx, timesy, false)
    } else {
        spiralOrderRec(matrix, 1, 0, timesx, timesy, true)
    }


}


function spiralOrder(matrix: number[][]): number[] {

    result = []
    spiralOrderRec(matrix, 1, 0, matrix[0].length, matrix.length, true)
    return result
};


console.log(spiralOrder([[1, 2, 3], [4, 5, 6], [7, 8, 9]]))