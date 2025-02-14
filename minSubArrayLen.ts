function minSubArrayLen(target: number, nums: number[]): number {
    let min = nums.length + 1
    let left = 0
    let index = 1

    let size = 1
    let sum = nums[left]

    while (left < nums.length) {
        if (sum >= target) {
            min = Math.min(min, size)
            sum -= nums[left++]
            size--
            continue
        }

        size++

        if (index < nums.length) {
            sum += nums[index++]
        } else {
            sum -= target[left++]
            size--
        }
    }


    return min == nums.length + 1 ? 0 : min
};

console.log(minSubArrayLen(7, [2, 3, 1, 2, 4, 3]))