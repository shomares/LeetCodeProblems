function increasingTriplet(nums: number[]): boolean {
    let a = Number.MAX_SAFE_INTEGER
    let b = Number.MAX_SAFE_INTEGER

    let index = 0

    while(index < nums.length){

        const c = nums[index]

        if(c > b){
            return true
        }else if (c > a){
            b = c
        }else if (c < a){
            a = c
        }

        index++
    }
    
    return false
};


console.log(increasingTriplet([20, 100, 10, 12, 5, 13]))