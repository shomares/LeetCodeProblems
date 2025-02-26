function rob(nums: number[]): number {

    if (nums.length === 1) {
        return nums[0]
    }

    const dp = new Array<number>(nums.length).fill(0)

    dp[0] = nums[0]
    dp[1] = nums[1]

    let index = 2;
    let max = Math.max(dp[0], dp[1])
    dp[1] = max

    while (index < nums.length) {
        const current = nums[index]
        const valueFirstTime = dp[index - 2]
        const sumAnt = current + valueFirstTime
        max = Math.max(sumAnt, dp[index - 1])
        dp[index] = max
        index++

    }


    return max
};


console.log(rob([1,3,1,3,100]))