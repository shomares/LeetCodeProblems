function jumpII(nums: number[]): number {
    const dp = new Array<number>(nums.length).fill(0)
    let index = nums.length - 2
    const finalGoal = nums.length - 1

    while (index >= 0) {

        const stepsAvailable = nums[index]
        const calc = stepsAvailable + index

        if (stepsAvailable == 0) {
            dp[index] = -1
            index--
            continue
        }

        if (calc >= finalGoal) {
            dp[index] = dp[index] + 1
            index--
            continue
        }

        let indexj = calc
        let minimunStep = -1
        const to = (calc - stepsAvailable) + 1

        while (indexj >= to) {
            const dpStep = dp[indexj]

            if (dpStep == -1) {
                indexj--
                continue
            }

            if (minimunStep == -1) {
                minimunStep = dpStep
            } else if (dpStep < minimunStep) {
                minimunStep = dpStep
            }
            indexj--
        }

        if (minimunStep == -1) {
            dp[index] = -1
        } else {
            dp[index] = 1 + minimunStep
        }


        index--
    }


    return dp[0]
};

console.log(jumpII([5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0]))