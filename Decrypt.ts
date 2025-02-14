function decrypt(code: number[], k: number): number[] {
    const result = new Array<number>(code.length).fill(0)

    let times = 0
    let sum = 0
    let index = k > 0 ? 1 : code.length - 1
    let indexk = 0

    if(k == 0){
        return result
    }

    while (times < Math.abs(k)) {
        if (k > 0 && index == code.length) {
            index = 0
        }

        if (k < 0 && index == -1) {
            index = code.length - 1
        }

        sum += code[index]
        index = k > 0 ? index + 1 : index - 1
        times++
    }

    result[0] = sum
    indexk = k > 0 ? index : 0
    let indexRemove = k > 0 ? 1 : index + 1
    index = 1

    while (index < code.length) {

        if (k > 0 && indexk == code.length) {
            indexk = 0
        }

        if (indexRemove == code.length) {
            indexRemove = 0
        }

        const leftToRemove = code[indexRemove]
        const toAdd = code[indexk]
        sum -= leftToRemove
        sum += toAdd
        result[index] = sum

        index++
        indexk++
        indexRemove++
    }

    return result
};

console.log(decrypt([2, 4, 9, 3], -2))