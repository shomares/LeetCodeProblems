//[1, -2, 10, -5]
function asteroidCollision(asteroids: number[]): number[] {
    const stack: number[] = [asteroids[0]]
    let index = 1

    while (index < asteroids.length) {
        let next = asteroids[index]
        let lastItem = stack[stack.length - 1]
        stack.push(next)

        while (stack.length > 1 && lastItem > 0 && next < 0) {
            const sizeLast = Math.abs(lastItem)
            const sizeNext = Math.abs(next)

            stack.pop()
            stack.pop()

            if (sizeNext > sizeLast) {
                stack.push(next)
            } else if (sizeNext < sizeLast) {
                stack.push(lastItem)
            }

            if(stack.length <= 1){
                break
            }
            lastItem = stack[stack.length - 2]
            next = stack[stack.length - 1]
        }


        index++

    }

    return stack
};

console.log(asteroidCollision([10, 2, -5]))