// 8. Proqrama il, ay, gün adında məlumat daxil edilir. 
//    Daxil edilən məlumatın yaşadığımız ilə kimi olan tarix formatına uğun olub olduğunu təyin edən proqram

int day = 04;
int month = 12;
int year = 2002;

if(day <= 31 && month <= 12 && year <= 2022 ){
   Console.WriteLine(day + "." + month + "." + year);
}
else
{
   Console.WriteLine("Tarix uyğun deyil");
}