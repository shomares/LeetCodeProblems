function compress(chars: string[]): number {
    let index = 0
    let times = 0

    let left = 0
    let count = 0
    let last: string = null

    while (index < chars.length) {
        const c = chars[index]

        if (last === null) {
            last = c
            times++
            index++
            continue
        }

        //its the same character
        if (last == c) {
            times++
            index++
            continue
        }

        count++
        chars[left] = last
        if (times > 1) {

            let timeStr = times.toString()
            let timeIndex = 0
            left++
            let startIndex = left
            while (timeIndex < timeStr.length) {
                chars[startIndex] = timeStr[timeIndex]
                left++
                timeIndex++
                startIndex++
                count++
            }

        } else {
            left++
        }



        times = 0
        last = c

    }

    if (times > 0) {
        chars[left] = last
        count++

        if (times > 1) {
            let timeStr = times.toString()
            let timeIndex = 0
            left++
            let startIndex = left
            while (timeIndex < timeStr.length) {
                chars[startIndex] = timeStr[timeIndex]
                left++
                timeIndex++
                startIndex++
                count++
            }
        }
    }

    console.log(chars)

    return count
};


console.log(compress(["a", "a", "b", "b", "c", "c", "c"]));