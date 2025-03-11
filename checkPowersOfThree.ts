

function checkPowersOfThreeRecursive(n: number, power: number): boolean {
    if (n === 0) {
        return true
    }

    const newPowerCalculated = Math.pow(3, power)

    if (newPowerCalculated > n) {
        return false
    }

    const resultA = checkPowersOfThreeRecursive(n - newPowerCalculated, power + 1)


    const resultB = checkPowersOfThreeRecursive(n, power + 1)


    return resultA || resultB


}




function checkPowersOfThree(n: number): boolean {
    return checkPowersOfThreeRecursive(n, 0)

};

console.log(checkPowersOfThree(12))