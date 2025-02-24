let founded: string | null = null

function recursiveGenerateNumber(size: number, prefix: string, cache: Set<string>) {
    if (prefix.length == size) {

        if (!cache.has(prefix)) {
            founded = prefix
        }

        return
    }

    if (!founded) {
        recursiveGenerateNumber(size, prefix + "0", cache)
    }


    if (!founded) {
        recursiveGenerateNumber(size, prefix + "1", cache)
    }
}


function findDifferentBinaryString(nums: string[]): string {
    founded = null

    recursiveGenerateNumber(nums[0].length, "", new Set(nums))
    return founded ?? ""
};

console.log(findDifferentBinaryString(["00", "01"]))