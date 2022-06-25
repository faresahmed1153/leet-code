/**
 * @param {string} s
 * @return {boolean}
 */
const isValid = function (s) {
  if (s.length < 2) return false;
  else {
    const arr = [];
    const hashMap = { "(": ")", "{": "}", "[": "]" };
    for (let char of s) {
      if (hashMap[char]) arr.push(hashMap[char]);
      else if (arr.length > 0 && arr[arr.length-1] === char) arr.pop();
      else return false;
    }
    return arr.length === 0;
  }
};