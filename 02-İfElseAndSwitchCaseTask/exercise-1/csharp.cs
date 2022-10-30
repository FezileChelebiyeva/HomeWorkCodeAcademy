// 2. 3 ədəd içindən cəmləri ən böyük olan 2 ədədi qaytarmaq

int a = 28;
int b = 83;
int c = 78;

if (a + b > b + c && a + b > a + c)
{
    Console.WriteLine(a + " " + b);
}
else if (b + c > b + a && b + c > a + c)
{
    Console.WriteLine(b + " " + c);
}
else if (a + c > b + c && a + c > a + b)
{
    Console.WriteLine(c + " " + a);
}

