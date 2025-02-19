function smallestNumber(pattern: string = "IIIDIDDD"): string {

    let index = 0
    const stack: number[] = []
    let result = ""

    while (index <= pattern.length) {
        stack.push(index + 1)
        if (index == pattern.length || pattern[index] == 'I') {
            while (stack.length > 0) {
                const toAdd = stack.pop()
                result += toAdd
            }
        }

        index++
    }
    return result
};


console.log(smallestNumber("IIIDIDDD"))