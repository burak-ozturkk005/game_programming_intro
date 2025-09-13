using System.Linq;
List<int> sayilar = new List<int>();
//mini uygulama
// kullanici 5 sayi girsin bu sayilarin max min ini bul hepsini foreach ile dön.
int sayac = 5;
int sayi;
bool basariliMi;
while (sayac > 0)
{
    Console.WriteLine("Lutfen sayi girin: ");
    basariliMi = int.TryParse(Console.ReadLine(), out sayi);
    sayilar.Add(sayi);
    sayac--;
    
}
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}
int max = sayilar[0];
int min = sayilar[0];

for (int i = 0; i < sayilar.Count; i++)
{
    if (sayilar[i] > max)
    {
        max = sayilar[i];
    }
    else if (sayilar[i] < min)
    {
        min = sayilar[i];
    }
}

Console.WriteLine("En büyük sayi: " + max);
Console.WriteLine("En küçük sayi: " + min);
//LINQ ile bulma
int max1 = sayilar.Max();
int min1 = sayilar.Min();
double ortalama = sayilar.Average();
int toplam = sayilar.Sum();
Console.WriteLine(toplam);
Console.WriteLine(ortalama);