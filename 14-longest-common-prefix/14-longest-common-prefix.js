/**
 * @param {string[]} strs
 * @return {string}
 */
const longestCommonPrefix = function (strs) {
  let prefix = "";
  if (strs.length == 0) return prefix;
  for (let i = 0; i < strs[0].length; i++) {
    const char = strs[0][i];
    console.log(char);
    for (let j = 0; j < strs.length; j++) {
      console.log(strs[j][i]);
      if (strs[j][i] !== char) return prefix;
    }
    prefix = prefix + char;
  }
  return prefix;
};

