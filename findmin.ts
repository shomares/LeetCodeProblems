function findMin(nums: number[]): number {
    let left = 0
    let right = nums.length - 1

    if (nums.length == 2) {
        return nums[0] > nums[1] ? nums[1] : nums[0]
    }

    while (left < right) {
        const middle = Math.floor(left + (right - left) / 2)

        const value = nums[middle]
        const valueRight = nums[right]
        const rightOneStep = nums[middle + 1]

        if (middle == 0) {
            if (rightOneStep < value) {
                return rightOneStep
            }
        } else {
            const leftOneStep = nums[middle - 1]
            if (leftOneStep > value && rightOneStep > value) {
                return value
            }
        }



        if (valueRight < value) {
            left = middle + 1
        } else {
            right = middle - 1
        }
    }

    return nums[left]
};

console.log(findMin([5, 1, 2, 3, 4]))