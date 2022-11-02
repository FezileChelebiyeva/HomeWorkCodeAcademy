let sampleNews = ("As software developers, the natural tendency is to start developing applications based on your own hands-on experience and knowledge right away. However, overtime issues in the application arise, adaptations to changes, and new features happen.");
let a = 0;
let b = 0;
for (let i = 0; i < sampleNews.length; i++)
{
    if (sampleNews[i] == ",")
    {
        a++;
    }
    if (sampleNews[i] == ".")
    {
        b++;
    }
}
console.log(a);
console.log(b);



// birlikde
// let sampleNews = "As software developers, the natural tendency is to start developing applications based on your own hands-on experience and knowledge right away. However, overtime issues in the application arise, adaptations to changes, and new features happen."
// let a = 0;
// for( let i=0; i < sampleNews.length; i++){
//      sampleNews[i];
//     if (sampleNews[i] !== "." && sampleNews[i] !== ",") {
//         continue
//     }
//     a++;
// } console.log(a)