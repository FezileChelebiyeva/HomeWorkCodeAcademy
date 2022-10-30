// See https://aka.ms/new-console-template for more information

// 3. 3 ədəd verilib. Bu ədədləri artan və azalan sıra ilə düzün.

//azalan sıra

int a = 6;
int b = 7;
int c = 8;

if (a > b && a > c)
{
    if (b > c)
    {
        Console.WriteLine(a + " " + b + " " + c);
    }
    else
    {
        Console.WriteLine(a + " " + c + " " + b);
    }
}
else if (b > c && b > a)
{
    if (c > a)
    {
        Console.WriteLine(b + " " + c + " " + a);
    }
    else
    {
        Console.WriteLine(b + " " + a + " " + c);
    }
}
else
{
    if (a > b)
    {
        Console.WriteLine(c + " " + a + " " + b);
    }
    else
    {
        Console.WriteLine(c + " " + b + " " + a);
    }
}


//artan sıra
int x = 6;
int y = 9;
int z = 10;

if (x < y && x < z)
{
    if (y < z)
    {
        Console.WriteLine(x + " " + y + " " + z);
    }
    else
    {
        Console.WriteLine(x + " " + z + " " + y);
        }
}
else if (y < z && y < x)
{
    if (z < x)
    {
        Console.WriteLine(y + " " + z + " " + x);
    }
    else
    {
        Console.WriteLine(y + " " + x + " " + z);
        }
}
else
{
    if (x < y)
    {
        Console.WriteLine(z + " " + x + " " + y);
    }
    else
    {
        Console.WriteLine(z + " " + y + " " + x);
    }
}