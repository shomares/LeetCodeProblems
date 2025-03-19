function maxOperationsNoHashset(nums: number[], k: number): number {
    let result = 0

    nums.sort((a, b) => a - b)

    let left = 0
    let right = nums.length - 1

    while (left < right) {
        const valueLeft = nums[left]
        const valueRight = nums[right]

        const sum = valueLeft + valueRight

        if (sum === k) {
            result++
            left++
            right--
        }

        else if (sum < k) {
            left++
        } else {
            right--
        }

    }

    return result
}



function maxOperations(nums: number[], k: number): number {
    const hashset = new Map<number, number>()
    let result = 0

    for (let item of nums) {
        if (hashset.has(item)) {
            hashset.set(item, hashset.get(item) + 1)
            continue
        }

        hashset.set(item, 1)
    }

    for (let item of nums) {
        const toFind = k - item

        if (hashset.has(toFind) && hashset.has(item) &&

            ((toFind !== item && hashset.get(item) > 0) || (toFind === item && hashset.get(item) > 1))


        ) {
            hashset.set(toFind, hashset.get(toFind) - 1)
            hashset.set(item, hashset.get(item) - 1)

            if (hashset.get(toFind) === 0) {
                hashset.delete(toFind)
            }

            if (hashset.get(item) === 0) {
                hashset.delete(item)
            }

            result++
        }

    }


    return result
};

console.log(maxOperationsNoHashset([3, 1, 3, 4, 3], 6))