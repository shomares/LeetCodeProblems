function twoSum(numbers: number[], target: number): number[] {
    let indexL = 0
    let indexR = numbers.length - 1

    while (indexL < indexR) {

        const a = numbers[indexL]
        const b = numbers[indexR]

        const sum = a + b

        if (sum == target) {
            return [indexL + 1, indexR + 1]
        }
        else if (sum > target) {
            indexR--
        } else {
            indexL++
        }
    }

    return []
};

console.log(twoSum([2,7,11,15], 9))