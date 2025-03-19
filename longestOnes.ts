function longestOnes(nums: number[], k: number): number {
    let index = 0
    let zeroes = 0
    let ones = 0
    let result = 0
    let left = 0

    while (index < nums.length) {
        const c = nums[index]

        if(c === 0){
            zeroes++
        }else{
            ones++
        }

        if(zeroes> k){
            if(nums[left] === 0){
                zeroes--
            }else{
                ones--
            }

            left++
        }else{
            result = Math.max(result, zeroes + ones)
        }

        index++
    }


    return result
};

console.log(longestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2))