function longestSubarray(nums: number[]): number {
    let index = 0
    let zeroes = 0
    let ones = 0
    let left = 0
    let result = 0

    while(index < nums.length){

        const c = nums[index]

        if(c === 1){
            ones++
        }else{
            zeroes++
        }

        if(zeroes >1){
            
            let valueOfLeft = nums[left]

            if(valueOfLeft === 0){
                zeroes--
            }else{
                ones--
            }

            left++
            index++
            continue
        }

        result = Math.max(result, ones)
        index++
    }
    
    if(result === nums.length){
        return result -1
    }
    return result
};

console.log(longestSubarray([0,1,1,1,0,1,1,0,1]))