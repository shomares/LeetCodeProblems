function pivotArray(nums: number[], pivot: number): number[] {
    let index = 0
    let right = 0
    let left = 0
    const result = new Array<number>(nums.length).fill(0)

    while (index < nums.length) {
        const current = nums[index]
        if (current <= pivot) {
            right++
        }

        index++
    }

    const rightPiv = right
    index =0
    while (index < nums.length) {
        const current = nums[index]

        if (current < pivot) {
            result[left] = current
            left++

        } else if (current > pivot) {
            result[right] = current
            right++
        }

        index++
    }

    while (left < rightPiv) {
        result[left] = pivot
        left++
    }

    return result


};

console.log(pivotArray([9, 12, 5, 10, 14, 3, 10], 10))