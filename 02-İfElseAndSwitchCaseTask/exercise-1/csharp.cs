// See https://aka.ms/new-console-template for more information

// 1. Ayın adlarına uyğun olaraq neçə gündən ibarət olması

string month = "december";

switch (month)
{
    case "january":
        Console.WriteLine("january has 31 days");
        break;
    case "february":
        Console.WriteLine("february 28 days");
        break;
    case "march":
        Console.WriteLine("march has 31 days");
        break;
    case "april":
        Console.WriteLine("april has 30 days");
        break;
    case "may":
        Console.WriteLine("may has 31 days");
        break;
    case "june":
        Console.WriteLine("june has 30 days");
        break;
    case "july":
        Console.WriteLine("july has 31 days");
        break;
    case "august":
        Console.WriteLine("august has 31 days");
        break;
    case "september":
        Console.WriteLine("september has 30 days");
        break;
    case "october":
        Console.WriteLine("october has 31 days");
        break;
    case "november":
        Console.WriteLine("november has 30 days");
        break;
    case "december":
        Console.WriteLine("december has 31 days");
        break;
    default:
        Console.WriteLine("this is not months");
        break;
}