function maxAbsoluteSum(nums: number[]): number {
    //getmax sum
    let index = 1
    let ant = nums[0]
    let resultMax = nums[0]

    while (index < nums.length) {
        const current = nums[index]
        const sumNew = current + ant
        const max = Math.max(current, sumNew)
        resultMax = Math.max(max, resultMax)
        ant = max
        index++
    }

    index = 1
    ant = nums[0]
    let resultMin = nums[0]
    while(index < nums.length){
        const current = nums[index]
        const sumNew = current + ant
        const min = Math.min(current, sumNew)
        resultMin = Math.min(min, resultMin)
        ant = min
        index++
    }

    return Math.max(resultMax, Math.abs(resultMin))
};


console.log(maxAbsoluteSum([2,-5,1,-4,3,-2]))