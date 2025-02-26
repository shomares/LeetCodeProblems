function kadane(nums: number[]): number {
    let index = 1
    let dp = new Array<number>(nums.length).fill(0)

    dp[0] = nums[0]

    while (index < nums.length) {
        const current = nums[index]
        const newSum = dp[index - 1] + current
        const max = Math.max(newSum, current)
        dp[index] = max
        index++
    }

    return Math.max(...dp)
};

function kadaneO1(nums: number[]): number {
    let index = 1
    let ant = nums[0]
    let result = ant

    while (index < nums.length) {
        const current = nums[index]
        const newSum = ant + current
        const max = Math.max(newSum, current)
        ant = max
        result = Math.max(max, result)
        index++
    }

    return result
};

console.log(kadaneO1([-2, 1, -3, 4, -1, 2, 1, -5, 4]))