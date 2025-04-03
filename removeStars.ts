function removeStars(s: string): string {
    const stack: string[] = []
    let index = 0

    while (index < s.length) {
        const c = s[index]

        if (c === '*' && stack.length > 0) {
            stack.pop()
        }else{
            stack.push(c)
        }

       
        index++
    }

    const result = new Array<string>(stack.length).fill('')

    index = result.length - 1

    while (index >= 0){
        result[index] = stack.pop()
        index--
    }

    return result.join('')
};

console.log(removeStars("leet**cod*e"))