// 8. Proqrama il, ay, gün adında məlumat daxil edilir. 
//    Daxil edilən məlumatın yaşadığımız ilə kimi olan tarix formatına uğun olub olduğunu təyin edən proqram

let day = 04
let month = 12
let year = 2002

if(day <= 31 && month <= 12 && year <= 2022 ){
    console.log(day+"."+month+"."+year)
}
else {
    console.log("Tarix uyğun deyil")
}