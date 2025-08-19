


function combinationSum2(candidates: number[], target: number): number[][] {
candidates.sort((a, b) => a - b);
  const res = [];
  const path = [];

  function dfs(start, sum) {
    if (sum === target) {
      res.push(path.slice());
      return;
    }
    for (let i = start; i < candidates.length; i++) {
      if (i > start && candidates[i] === candidates[i - 1]) continue;
      const val = candidates[i];
      if (sum + val > target) break;
      path.push(val);
      dfs(i + 1, sum + val);
      path.pop();
    }
  }

  dfs(0, 0);
  return res;
};


console.log(combinationSum2([1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1], 27))