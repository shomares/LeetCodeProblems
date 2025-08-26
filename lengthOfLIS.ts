function lengthOfLIS(nums: number[]): number {


    if(nums.length === 1) return 1;

    const dp = new Array(nums.length).fill(0);

    dp[nums.length - 1] = 1;
    dp[nums.length - 2] = 1;

     let max = 1;
    if(nums[nums.length - 2] < nums[nums.length - 1]) {
        dp[nums.length - 2] = 2;
        max = 2;
    }

    if(nums.length === 2) return dp[0];


   
    for(let i = nums.length - 3; i >= 0; i--) {

        const currentNum = nums[i]

        for(let j = i+1; j < nums.length; j++) {
            if(currentNum < nums[j]) {
                dp[i] = Math.max(dp[j], dp[i])
            } 
        }

        dp[i] = dp[i] + 1;
        max = Math.max(max, dp[i]);
    }

    return max;
};

console.log(lengthOfLIS([1, 2, 4, 3])); // 4