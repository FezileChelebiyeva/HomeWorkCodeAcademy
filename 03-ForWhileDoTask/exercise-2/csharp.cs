int a = 91;
int number = 1;
for (int i = 2; i < a; i++)
{
    if (a % i == 0)
    {
        number = 0;
    }
}
if (number == 1)
{
    Console.WriteLine($"{a} cavab - sadədir");
}
else
{
    Console.WriteLine($"{a} cavab - mürəkkəbdir");
}