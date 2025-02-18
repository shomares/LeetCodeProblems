const cache = new Set<string>()
const calculatePossibilites = (preffix: string, tilesArray: string[]) => {
    cache.add(preffix)
    let index = 0
    let copyTilesArray = [...tilesArray]
    for (const item of tilesArray) {
        const preff = preffix + item
        copyTilesArray.splice(index, 1)
        calculatePossibilites(preff, copyTilesArray)
        copyTilesArray = [...tilesArray]
        index++
    }
}

function numTilePossibilities(tiles: string): number {
    let array = [...tiles]
    cache.clear()

    let index = 0
    for (const item of tiles) {
        cache.add(item)
        array.splice(index, 1)
        calculatePossibilites(item, array)
        array = [...tiles]
        index++
    }

    return cache.size
};

console.log(numTilePossibilities("ABC"))