/**
 * @param {string} s
 * @return {number}
 */
const romanToInt = function (s) {
  const I = 1;
  const IV = 4;
  const V = 5;
  const IX = 9;
  const X = 10;
  const XL = 40;
  const L = 50;
  const XC = 90;
  const C = 100;
  const CD = 400;
  const D = 500;
  const CM = 900;
  const M = 1000;
  const str = s.split("").join("+").split("I+V").join("IV").split("I+X").join("IX").split("X+L").join("XL").split("X+C").join("XC").split("C+D").join("CD").split("C+M").join("CM");

  return eval(str);
};