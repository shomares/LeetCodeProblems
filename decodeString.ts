function decodeString(s: string): string {
    const stack: string[] = []
    const stackNumbers: number[] = []
    let strNumber = ''  
    let index = 0

    while (index < s.length) {
        let c = s[index]


        if (c >= '0' && c <= '9') {
            strNumber += c
            index++
            continue
        }
        else if ((c >= 'a' && c <= 'z') || c == '[') {
            if (strNumber !== '') {
                stackNumbers.push(Number.parseInt(strNumber))
                strNumber = ''
            }

            stack.push(c)
            index++
            continue
        }

        const newStack: string[] = []
        while (stack.length > 0) {

            c = stack.pop()

            if (c === '[') {
                break
            }

            newStack.push(c)
        }

        const times = stackNumbers.pop() ?? 1

        let indexj = 0
        let indexk = 0

        while (indexj < times) {
            indexk = newStack.length -1
            while (indexk >= 0) {
                stack.push(newStack[indexk])
                indexk--
            }

            indexj++
        }


        index++
    }


    return stack.join('')

};

console.log(decodeString("2[3[a2[c]]d]e"))