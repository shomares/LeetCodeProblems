function combinationSum3(k: number, n: number): number[][] {
    const result: number[][] = []

    function dnf(start: number, sumRec: number, array: number[]) {
        if (sumRec === n && array.length === k) {
            result.push([...array])
            return
        }

        for (let i = start; i <= 9; i++) {
            array.push(i)
            dnf(i + 1, sumRec + i, array)
            array.pop()
        }

    }

    dnf(1, 0, [])


    return result

};

console.log(combinationSum3(3, 7))