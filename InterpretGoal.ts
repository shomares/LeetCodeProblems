function interpret(command: string): string {
    let index = 0
    let result = ""

    while (index < command.length) {
        let c = command[index]

        if (c == "(") {
            let countValues = 0
            while (index < command.length && c != ")") {
                c = command[index++]
                countValues++
            }

            if (countValues > 2) {
                result = "o"
            } else {
                result = "al"
            }
        } else {
            result += "G"
            index++

        }

    }

    return result
};

console.log(interpret("G()(al)"))