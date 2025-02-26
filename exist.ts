function startToFindRecursive(board: string[][],
    characterIndex: number,
    word: string,
    x: number,
    y: number): boolean {

    if (characterIndex == word.length) {
        return true
    }

    if (x < 0 || x >= board[0].length) {
        return false
    }

    if (y < 0 || y >= board.length) {
        return false
    }

    const c = board[y][x]

    if (c == '#' || c != word[characterIndex]) {
        return false
    }

    board[y][x] = '#'
    //Right
    let characterIndexToValue = characterIndex + 1

    if (startToFindRecursive(board, characterIndexToValue, word, x + 1, y)) {
        return true
    }


    if (startToFindRecursive(board, characterIndexToValue, word, x - 1, y)) {
        return true
    }

    if (startToFindRecursive(board, characterIndexToValue, word, x, y + 1)) {
        return true
    }

    if (startToFindRecursive(board, characterIndexToValue, word, x, y - 1)) {
        return true
    }

    board[y][x] = c

}

function exist(board: string[][], word: string): boolean {
    let index = 0
    while (index < board.length) {
        let indexj = 0

        while (indexj < board[index].length) {
            const result = startToFindRecursive(board, 0, word, indexj, index)
            if (result) {
                return true
            }
            indexj++
        }

        index++
    }

    return false
};

console.log(exist([["A", "B", "C", "E"], ["S", "F", "E", "S"], ["A", "D", "E", "E"]], "ABCESEEEFS"))