// while
let m = 256
let n = 2
let z = m
let a = 0;
while(m % n == 0)
{
    m = m / n
    a++;
}
if (m == 1){
    console.log(`cavab - ${a}`)}
 
else {
    console.log(`${z} ededi ${n} ededinin quvveti deil`)
}


// for
let x = 243
let y = 3
let sum = x;
let b = 0;
for(let i = x; i > 1; i--){
    sum = sum / y;
    b++
    if( sum == 1){
        console.log(`cavab - ${b}`)
        break;
    }
    if(i == 2 ){
        console.log("quvvet deil");
        break;
    }
}

