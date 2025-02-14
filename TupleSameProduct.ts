function tupleSameProduct(nums: number[]): number {

    let index = 0
    const map = new Map<number, number[][]>()

    while (index < nums.length) {
        let indexj = index + 1
        let a = nums[index]
        while (indexj < nums.length) {
            let b = nums[indexj]
            let product = a * b
            if (map.has(product)) {
                const array = map.get(product)
                array.push([a, b])
                map.set(product, array)
            } else {
                map.set(product, [[a, b]])
            }

            indexj++
        }

        index++

    }

    let sum = 0;

    for (let values of map.values()) {
        if (values.length >= 2) {
            let n = values.length
            sum += n * (n - 1) * 4
        }
    }



    return sum
};

console.log(tupleSameProduct([2, 3, 4, 6]))