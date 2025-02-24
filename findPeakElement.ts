function findPeakElement(nums: number[]): number {
    let left = 0
    let right = nums.length - 1


    if(nums.length == 1){
        return 0
    }

    if (nums[right] > nums[right - 1]) {
        return right
    }

    if (nums[left] > nums[left + 1]) {
        return left
    }

    while (left < right) {

        const middle = Math.floor(left + (right - left) / 2)
        const leftValue = nums[middle - 1]
        const rightValue = nums[middle + 1]
        const value = nums[middle]

        if (value > leftValue && value > rightValue) {
            return middle
        }

        if (rightValue > value) {
            left = middle
            continue
        }

        right = middle
    }


    return -1
};

console.log(findPeakElement([1, 1, 1, 1, 10]))