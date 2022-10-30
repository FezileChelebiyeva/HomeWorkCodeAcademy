// 5. 3 rəqəmli hər hansı bir ədədin hansı rəqəmlərdən ibarət olduğunu bizə qaytaran bir proqram

int a = 273;

int first = a / 100;
int second = (a % 100) / 10;
int third = (a % 100) - second * 10;

Console.WriteLine(first + ", " + second + ", " + third);