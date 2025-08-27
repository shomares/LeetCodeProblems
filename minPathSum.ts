function minPathSum(grid: number[][]): number {

    const dp: number[][] = new Array(grid.length).fill(0).map(() => new Array(grid[0].length).fill(0));

    for(let i = grid.length -1 ; i>=0; i--) {
        for(let j = grid[0].length -1; j>=0; j--)
        {
            const current = grid[i][j];
            if(i == grid.length -1 && j == grid[0].length -1) {
                dp[i][j] = current
            }
            else if(i == grid.length-1){
                dp[i][j] = current + dp[i][j+1]
            }
            else if(j == grid[0].length -1) {
                dp[i][j] = current + dp[i+1][j]
            }else{  
                dp[i][j] = current + Math.min(dp[i+1][j], dp[i][j+1])
            }
           
        }
    }

    
    return dp[0][0];
};

console.log(minPathSum([[1,3,1],[1,5,1],[4,2,1]])); // 7