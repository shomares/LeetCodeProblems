type Points = {
    x: number,
    y: number

}


function orangesRotting(grid: number[][]): number {
    let result = 0
    let queque: Points[] = []
    let index = 0
    let numofOranges = 0

    while (index < grid.length) {
        let indexj = 0
        while (indexj < grid[index].length) {
            const value = grid[index][indexj]
            if (value === 2) {
                queque.push({
                    x: indexj,
                    y: index
                })
            }

            if (value === 1) {
                numofOranges++
            }

            indexj++
        }

        index++
    }

    const hash = new Set<string>()
    let orangesChanged = 0

    while (queque.length > 0) {
        let size = queque.length
        let times = 0
        let changes = 0

        while (queque.length > 0 && times < size) {
            const { x, y } = queque.shift()

            const key = `${x}:${y}`

            if (hash.has(key)) {
                times++
                continue
            }

            hash.add(key)
            //Left
            const left = x - 1
            if (left >= 0) {
                if (grid[y][left] === 1) {
                    grid[y][left] = 2
                    changes++
                    orangesChanged++
                    queque.push({
                        x: left,
                        y
                    })

                }
            }

            //Right
            const right = x + 1

            if (right < grid[y].length) {
                if (grid[y][right] === 1) {
                    grid[y][right] = 2
                    changes++
                    orangesChanged++
                    queque.push({
                        x: right,
                        y
                    })

                }

            }

            //Up
            const up = y - 1
            if (up >= 0) {
                if (grid[up][x] === 1) {
                    grid[up][x] = 2
                    changes++
                    orangesChanged++
                    queque.push({
                        x,
                        y: up
                    })

                }
            }

            //Down
            const down = y + 1
            if (down < grid.length) {
                if (grid[down][x] === 1) {
                    grid[down][x] = 2
                    changes++
                    orangesChanged++
                    queque.push({
                        x,
                        y: down
                    })

                }
            }

            times++
        }

        if (changes > 0) {
            result++
        }

    }

    return orangesChanged === numofOranges ? result : -1
}





console.log(orangesRotting([[2,1,1],[0,1,1],[1,0,1]]))