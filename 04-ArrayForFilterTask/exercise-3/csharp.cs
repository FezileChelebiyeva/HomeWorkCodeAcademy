string sampleNews = ("As software developers, the natural tendency is to start developing applications based on your own hands-on experience and knowledge right away. However, overtime issues in the application arise, adaptations to changes, and new features happen.");
int a = 0;
int bosh;
for (int i = 0; i < sampleNews.Length; i++)
{
    bosh = sampleNews[i];
    if (bosh == ' ')
    {
        a++;
    }
}
Console.WriteLine(a);