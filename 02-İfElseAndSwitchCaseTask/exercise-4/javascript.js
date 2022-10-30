// 4. 3 ədəd verilib. Bu ədədlərin birləşməsindən yaranan ən böyük və ən kiçik 3 rəqəmli ədədi tapan proqram
let a = 9
let b = 7
let c = 8
let max;
let min;
if(a > b && b > c && a > c){
    max = a*100+b*10+c
    min = c*100+b*10+a
        console.log("max: " + max)
        console.log("min: " + min) 
    if(c > b) {
    max = a*100+c*10+b
    min = b*100+c*10+a
        console.log("max: " + max)
        console.log("min: " + min)
    }
}
else if(b > a && b > c && c > a){
    max = b*100+c*10+a
    min = a*100+c*10+b
        console.log("max: " + max)
        console.log("min: " + min)
    if(a > c){
        max = b*100+a*10+c
        min = c*100+a*10+b
            console.log("max: " + max)
            console.log("min: " + min)
    }
}
else if(c > a && c > b && a > b) {
    max = c*100+a*10+b
    min = b*100+a*10+c
        console.log("max: " + max)
        console.log("min: " + min)
}
else {
    max = c*100+b*10+a
    min = a*100+b*10+c
        console.log("max: " + max)
        console.log("min: " + min)
}