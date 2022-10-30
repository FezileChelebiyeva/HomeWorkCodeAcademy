// 6. Proqrama daxil edilən məlumatın ədəd və ya  hərf, simvol olduğunu təyin edən proqram

// ədəd
int a = 32;

if (a.GetType() == typeof(int))
{
   Console.WriteLine("Daxil edilən məlumat rəqəmdir");
}

// hərf
string b = "a";

if (b.GetType() == typeof(string))
{
   Console.WriteLine("Daxil edilən məlumat hərf və ya simvoldur");
}

// simvol
string c = "/";

if (c.GetType() == typeof(string))
{
   Console.WriteLine("Daxil edilən məlumat hərf və ya simvoldur");
}