// 7. Düzbucaqlı üçbucağın katetləri və hipotenuzunun uzunluğu verilib. 
//   Verilən məlumatlara əsəsən bu üçbucağın düzbucaqlı üçbucaq olub olmadığını yoxlayan proqram 

using System;
int a = 6;
int b = 8;
int c = 10;

if (a*a + (b*b) == (c*c)) 
{
   Console.WriteLine("düzbucaqlı üçbucaqdır");
}
else 
{
   Console.WriteLine("düzbucaqlı üçbucaq deyil");
}