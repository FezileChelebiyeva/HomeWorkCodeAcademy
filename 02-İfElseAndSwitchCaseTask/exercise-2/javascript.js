// 2. 3 ədəd içindən cəmləri ən böyük olan 2 ədədi qaytarmaq

let a = 28;
let b = 83;
let c = 98;

if(a+b>b+c && a+b>a+c)
{
    console.log(a+" "+b)
}
else if(b+c>b+a && b+c>a+c)
{
    console.log(b+" "+c)
}
else if(a+c>b+c && a+c>a+b)
{
    console.log(c+" "+a)
}