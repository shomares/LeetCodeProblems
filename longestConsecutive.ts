function longestConsecutive(nums: number[]): number {
    const hashset = new Set<number>(nums)
    let index = 0
    let maxvalue = 0

    while (index < nums.length) {
        let item = nums[index]

        if(!hashset.has(item)){
            index++
            continue
        }

        //exists item and no item in left
        if (hashset.has(item - 1)) {
            index++
            continue
        }

        let count = 0
        while (hashset.has(item)) {
            hashset.delete(item)
            count++
            item++
        }

        maxvalue = Math.max(count, maxvalue)
        index++
    }
    
    return maxvalue
};

console.log(longestConsecutive([100, 4, 200, 1, 3, 2]));