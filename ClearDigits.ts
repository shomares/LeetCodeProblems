function clearDigits(s: string): string {
    const stack: string[] = []

    let index = 0

    while (index < s.length) {
        let c = s[index++]
        if (c >= '0' && c <= '9' && c.length > 0) {
            stack.pop()
        } else {
            stack.push(c)
        }
    }

    let result = new Array(stack.length)
    index = stack.length - 1



    while (stack.length > 0) {
        result[index] = stack.pop()
        index--
    }

    return result.join("")
};

console.log(clearDigits("cb34"))