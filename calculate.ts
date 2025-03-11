function calculate(s: string): number {
    const clearS: Array<string> = []
    let index = 0
    let str = ''

    while (index < s.length) {
        const c = s[index]
        if (c === ' ') {
            index++
            continue
        }

        if (c >= '0' && c <= '9') {
            str += c
            index++
            continue
        }

        if (clearS.length === 0 && c == '-') {
            str += c
            index++
            continue
        }

        if (str !== '') {
            clearS.push(str)
        }

        clearS.push(c)
        str = ''
        index++
    }

    if (str != '' && str != ' ') {
        clearS.push(str)
    }


    let operator: string | null = null
    let ant: number | null = null
    let finalRes = ''
    while (clearS.length > 0) {
        const lastValue = clearS.pop()

        if (lastValue === '+' || lastValue == '-') {
            operator = lastValue
            continue
        }

        if (lastValue == '(') {
            clearS.push(finalRes)
        }

        const y = Number.parseInt(lastValue)
        if (ant == null) {
            ant = y
            continue
        }

        if (operator == null) {
            continue
        }

        let result = 0
        if (operator == '+') {
            result = y + ant
        } else if (operator == '-') {
            result = y - ant
        }

        const toAdd = result.toString()
        clearS.push(toAdd)
        finalRes = toAdd
        operator = null
        ant = null
    }

    return Number.parseInt(finalRes)
};

console.log(calculate("2+((4-3)+1)"))