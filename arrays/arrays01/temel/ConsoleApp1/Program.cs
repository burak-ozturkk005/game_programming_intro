//Arrays
int[] sayilar = [3, 4, 5, 6, 7];
for(int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}
Console.WriteLine(sayilar[2]);
foreach(int s in sayilar)
{
    Console.WriteLine(s);
}
List<string> isimler = new List<string>() { "burak", "ismet", "gundi" };
foreach(string isim in isimler)
{
    Console.WriteLine(isim);
}

