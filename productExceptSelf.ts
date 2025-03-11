function productExceptSelf(nums: number[]): number[] {
    let result = new Array<number>(nums.length).fill(0)
    let index = nums.length - 2
    result[result.length - 1] = nums[nums.length - 1]
    while (index >= 0) {
        result[index] = result[index + 1] * nums[index]
        index--
    }

    let ant = 1
    index = 0

    while (index < result.length) {
        const caculate = ant * (index === result.length - 1 ? 1 : result[index + 1]);
        result[index] = caculate
        ant *= nums[index]
        index++
    }
    return result
};

console.log(productExceptSelf([1, 2, 3, 4]))