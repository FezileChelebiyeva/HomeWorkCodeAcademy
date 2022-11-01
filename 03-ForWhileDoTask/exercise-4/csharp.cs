using System;
// while
float m = 255;
float n = 2;
float z = m;
float a = 0;
while (m % n == 0)
{
    m = m / n;
    a++;
}
if (m == 1)
{
    Console.WriteLine($"{a} - cavabdir");
}
else
{
    Console.WriteLine($"{z} ededi ${n} ededinin quvveti deil");
}


// for
float x = 343;
float y = 3;
float sum = x;
float b = 0;
for (float i = x; i > 1; i--)
{
    sum = sum / y;
    b++;
    if (sum == 1)
    {
        Console.WriteLine($"{b} - cavabdir");
        break;
    }
    if (i == 2)
{
    Console.WriteLine("quvvet deil");
    break;
}
}