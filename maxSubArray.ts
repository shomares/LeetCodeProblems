function maxSubArray(nums: number[]): number {
    let index = 1
    let ant = nums[0]
    let result =nums[0]

    while (index < nums.length) {
        const current = nums[index]
        const sum = nums[index] +ant

        const max = Math.max(current, sum)
        result = Math.max(result, max)
        ant = max
        index++
    }

    return result
};

console.log(maxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]))