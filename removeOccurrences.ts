function removeOccurrences(s: string, part: string): string {
    let index = 0
    const stack: string[] = []
    const lastItem = part[part.length - 1]

    while (index < s.length) {
        const c = part[index]
        stack.push(c)

        if (c == lastItem) {

            let indexPart = part.length - 1
            let stackCount = stack.length - 1
            let countEqual = 0
            
            while (indexPart >= 0 && stack.length > 0) {
                const goBackC = stack[stackCount]
                if (goBackC != part[indexPart]) {
                    break
                }

                indexPart--
                countEqual++
            }

            if(countEqual == part.length){
                let indexk = 0
                while(indexk< countEqual){
                    stack.pop()
                    indexk++
                }
            }
        }
    
        index++

    }

    return stack.join("")
};

console.log(removeOccurrences("daabcbaabcbc", "abc"))