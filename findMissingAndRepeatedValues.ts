
function findMissingAndRepeatedValues(grid: number[][]): number[] {
    const hash = new Set<number>()
    let x: number = null
    let y: number = null

    let sum: number = 0
    let shouldbeSum = 0
    let index = 0
    let counter = 0

    while (index < grid.length) {
        let row = grid[index]
        let indexj = 0

        while (indexj < row.length) {
            let value = grid[index][indexj]
            sum += value
            counter++
            shouldbeSum += counter

            if (hash.has(value)) {
                y = value
            }

            hash.add(value)

            indexj++
        }

        index++
    }

    const removeRepetaded = sum - y
    x = shouldbeSum - removeRepetaded
    return [y, x]
};


console.log(findMissingAndRepeatedValues([[1, 3], [2, 2]]))