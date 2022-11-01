let a = 987
let number = 1;
for(let i = 2; i < a; i++){
    if(a % i == 0){
        number = 0;
    }
}
if(number == 1){
   console.log(`${a} cavab-sadədir`) 
}
else {
   console.log(`${a} cavab-mürəkkəbdir`) 
}
