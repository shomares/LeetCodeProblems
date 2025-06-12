const findSuccessFull = (spell: number, potions: number[], success: number): number => {
    let left = 0
    let right = potions.length - 1

    while (left <= right) {
        let middle = Math.floor(left + (right - left) / 2)
        let valueCalculate = spell * potions[middle]
        if (valueCalculate >= success) {
            right = middle - 1
        } else {
            left = middle + 1
        }
    }


    return potions.length - left
}



function successfulPairs(spells: number[], potions: number[], success: number): number[] {
    const potionsSorted = potions.sort((a, b) => a - b);
    const result: number[] = []
    let index = 0

    while (index < spells.length) {
        result[index] = findSuccessFull(spells[index], potionsSorted, success)
        index++
    }


    return result
};


console.log(successfulPairs([40, 11, 24, 28, 40, 22, 26, 38, 28, 10, 31, 16, 10, 37, 13, 21, 9, 22, 21, 18, 34, 2, 40, 40, 6, 16, 9, 14, 14, 15, 37, 15, 32, 4, 27, 20, 24, 12, 26, 39, 32, 39, 20, 19, 22, 33, 2, 22, 9, 18, 12, 5], [31, 40, 29, 19, 27, 16, 25, 8, 33, 25, 36, 21, 7, 27, 40, 24, 18, 26, 32, 25, 22, 21, 38, 22, 37, 34, 15, 36, 21, 22, 37, 14, 31, 20, 36, 27, 28, 32, 21, 26, 33, 37, 27, 39, 19, 36, 20, 23, 25, 39, 40], 600))