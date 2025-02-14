function queryResults(limit: number, queries: number[][]): number[] {
    const mapBallToColor = new Map<number, number>()
    const mapColorToBall = new Map<number, number>()
    const result: number[] = new Array(queries.length).fill(0)
    let index = 0
    while (index < queries.length) {
        const array = queries[index]
        const ball = array[0]
        const colorBall = array[1]


        if (mapBallToColor.has(ball)) {
            let color = mapBallToColor.get(ball)

            if (mapColorToBall.has(color)) {
                let balls = mapColorToBall.get(color)
                balls--
                mapColorToBall.set(color, balls)
                if (balls == 0) {
                    mapColorToBall.delete(color)
                }
            } else {
                mapColorToBall.set(colorBall, 1)
            }
        }

        mapBallToColor.set(ball, colorBall)
        if (mapColorToBall.has(colorBall)) {
            let arrayBalls = mapColorToBall.get(colorBall)
            arrayBalls++
            mapColorToBall.set(colorBall, arrayBalls)
        } else {
            mapColorToBall.set(colorBall, 1)
        }

        result[index] = mapColorToBall.size
        index++

    }

    return result
};

console.log(queryResults(4, [[1, 4], [2, 5], [1, 3], [3, 4]]))