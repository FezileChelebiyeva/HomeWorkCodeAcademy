string sampleNews = ("As software developers, the natural tendency is to start developing applications based on your own hands-on experience and knowledge right away. However, overtime issues in the application arise, adaptations to changes, and new features happen.");
int a = 0;
int b = 0;
for (int i = 0; i < sampleNews.Length; i++)
{
    if (sampleNews[i] == ',')
    {
        a++;
    }
    if (sampleNews[i] == '.')
    {
        b++;
    }
}
Console.WriteLine(a);
Console.WriteLine(b);