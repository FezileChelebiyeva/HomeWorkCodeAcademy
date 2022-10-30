// 5. 3 rəqəmli hər hansı bir ədədin hansı rəqəmlərdən ibarət olduğunu bizə qaytaran bir proqram
let a = 956;

let first = (a / 100) - (a % 100)/100;
let second = (a % 100) / 10 - (a%10)/10;
let third = (a % 100) - second * 10;

console.log(first + ", " + second + ", " + third);
