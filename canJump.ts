function canJump(nums: number[]): boolean {
    if (nums.length == 1) {
        return true
    }

    let goal = nums.length - 1
    let toValidate = nums.length - 2

    while (toValidate >= 0) {
        const lastNumberToValidate = nums[toValidate]

        if (toValidate + lastNumberToValidate >= goal) {
            goal = toValidate

            if (toValidate == 0) {
                return true
            }
        }

        toValidate--
    }


    return false
};

console.log(canJump([1, 1, 2, 5, 2, 1, 0, 0, 1, 3]))
