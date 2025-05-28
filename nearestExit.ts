type Point = {
    x: number,
    y: number,
    step: number
}


function nearestExit(maze: string[][], entrance: number[]): number {

    const queque: Point[] = []


    queque.push({
        step: 0,
        x: entrance[1],
        y: entrance[0]
    })

    const visited: string[][] = []

    for (let index = 0; index < maze.length; index++) {
        visited.push([])
        for (let indexj = 0; indexj < maze[index].length; indexj++) {
            visited[index][indexj] = ''
        }
    }


    while (queque.length > 0) {
        const last = queque.shift()


        const { step, x, y } = last

        if (visited[y][x] === 'V') {
            continue
        }

        visited[y][x] = 'V'

        //Find all neighbors
        //Left -> Right

        if (x - 1 < 0) {
            if (step > 0) {
                return step
            }

        } else {
            const left = maze[y][x - 1]

            if (left === ".") {
                queque.push({
                    step: step + 1,
                    x: x - 1,
                    y
                })
            }
        }



        if (x + 1 >= maze[0].length) {
            if (step > 0) {
                return step
            }

        } else {
            const right = maze[y][x + 1]
            if (right === ".") {
                queque.push({
                    step: step + 1,
                    x: x + 1,
                    y
                })
            }
        }

        //Top -> down

        if (y + 1 >= maze.length) {
            if (step > 0) {
                return step
            }

        } else {
            const top = maze[y + 1][x]
            if (top === ".") {
                queque.push({
                    step: step + 1,
                    x: x,
                    y: y + 1
                })
            }
        }




        if (y - 1 < 0) {
            if (step > 0) {
                return step
            }

        } else {
            const down = maze[y - 1][x]

            if (down === ".") {
                queque.push({
                    step: step + 1,
                    x: x,
                    y: y - 1
                })
            }
        }


    }

    return -1
};

//console.log(nearestExit([[".","+"]], [0, 0]))