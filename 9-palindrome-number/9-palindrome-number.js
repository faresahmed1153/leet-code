/**
 * @param {number} x
 * @return {boolean}
 */
const isPalindrome = function (x) {
  if (x < 0) {
    return false;
  } else {
    const str = x.toString();
    const rev = str.split("").reverse().join("");
    if (str == rev) {
      return true;
    } else {
      return false;
    }
  }
};