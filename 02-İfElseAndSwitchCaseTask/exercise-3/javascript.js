// 3. 3 ədəd verilib. Bu ədədləri artan və azalan sıra ilə düzün.

// azalan sıra
let a = 6;
let b = 9;
let c = 8;

if (a > b && a > c) {
    if (b > c) { 
        console.log(a+" "+b+" "+c);
    } else {
        console.log(a+" "+c+" "+b) 
        }
    } 
else if (b > c && b > a) {
    if (c > a) {
        console.log(b+" "+c+" "+a); 
    }     
    else {
        console.log(b+" "+a+" "+c) 
        }
    }
else {
    if(a > b){
        console.log(c+" "+a+" "+b);
      }
     else{
        console.log(c+" "+b+" "+a);
        }
    }
   

//artan sıra
let x = 6;
let y = 9;
let z = 10;

if (x < y && x < z) {
    if (y < z) { 
        console.log(x+" "+y+" "+z);
    } else {
        console.log(x+" "+z+" "+y) 
        }
    } 
else if (y < z && y < x) {
    if (z < x) {
        console.log(y+" "+z+" "+x); 
    }     
    else {
        console.log(y+" "+x+" "+z) 
        }
    }
else {
    if(x < y){
        console.log(z+" "+x+" "+y);
      }
     else{
        console.log(z+" "+y+" "+x);
        }
    }