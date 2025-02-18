function simplifyPath(path: string = "/."): string {
    const stack: string[] = []
    let index = 0
    let directoryPath = ""

    while (index < path.length) {
        const c = path[index++]
        if (c == '/') {
            if (directoryPath == "" || directoryPath == ".") {
                directoryPath = ""
                continue
            }

            if (directoryPath == "..") {
                directoryPath = ""

                if (stack.length > 0) {
                    stack.pop()
                }

                continue;
            }

            stack.push(directoryPath)
            directoryPath = ""
            continue
        }

        directoryPath += c
    }

    if (directoryPath == ".." && stack.length > 0) {
        stack.pop()
    } else if (directoryPath != "" && directoryPath != "." && directoryPath != "..") {
        stack.push(directoryPath)
    }

    return "/" + stack.join("/")
};


console.log(simplifyPath("/."))