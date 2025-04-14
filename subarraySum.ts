function subarraySum(nums: number[], k: number): number {
    const hashmap = new Map<number, number>()
    hashmap.set(0, 1)
    let sum = 0
    let result = 0
    let index = 0

    while (index < nums.length) {
        sum += nums[index]

        if (hashmap.has(sum - k)) {
            result += hashmap.get(sum - k)
        }

        hashmap.set(sum, (hashmap.get(sum) ?? 0) + 1)

        index++
    }

    return result
};

console.log(subarraySum([1], 0))