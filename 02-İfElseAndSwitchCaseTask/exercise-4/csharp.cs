// 4. 3 ədəd verilib. Bu ədədlərin birləşməsindən yaranan ən böyük və ən kiçik 3 rəqəmli ədədi tapan proqram

int a = 2;
int b = 9;
int c = 8;
int max;
int min;
if (a > b && b > c && a > c)
{
       max = a * 100 + b * 10 + c;
    min = c * 100 + b * 10 + a;
        Console.WriteLine("max: " + max);
        Console.WriteLine("min: " + min);
    if (c > b)
   {
     max = a * 100 + c * 10 + b;
     min = b * 100 + c * 10 + a;
       Console.WriteLine("max: " + max);
       Console.WriteLine("min: " + min);
    }
}
else if (b > a && b > c && c > a)
{
    max = b * 100 + c * 10 + a;
    min = a * 100 + c * 10 + b;
       Console.WriteLine("max: " + max);
       Console.WriteLine("min: " + min);
    if (a > c)
   {
     max = b * 100 + a * 10 + c;
     min = c * 100 + a * 10 + b;
        Console.WriteLine("max: " + max);
        Console.WriteLine("min: " + min);
    }
}
else if (c > a && c > b && a > b)
{
     max = c * 100 + a * 10 + b;
     min = b * 100 + a * 10 + c;
        Console.WriteLine("max: " + max);
        Console.WriteLine("min: " + min);
}  
else
{
   max = c * 100 + b * 10 + a;
   min = a * 100 + b * 10 + c;
        Console.WriteLine("max: " + max);
        Console.WriteLine("min: " + min);
}