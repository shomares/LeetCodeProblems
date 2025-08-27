function longestCommonSubsequence(text1: string, text2: string): number {
    if(text1.length === 0 || text2.length === 0) return 0;
    
    const dp: number[][] = new Array(text1.length + 1).fill(0).map(() => new Array(text2.length + 1).fill(0));
    for (let i = text1.length -1; i  >=0; i--) {
        const currentCharText1 = text1[i]
        for (let j = text2.length-1; j >=0; j--) {
            const currentCharText2 = text2[j];
            if(currentCharText1 == currentCharText2){
                dp[i][j]= 1 + dp[i+1][j+1];
            }else{
                dp[i][j] = Math.max(dp[i+1][j], dp[i][j+1]);
            }
        }

    };

    return dp[0][0];
 
}

    console.log(longestCommonSubsequence("abcde", "ace")); // 3