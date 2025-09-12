//Liste oluştur.
List<string> meyveler = new List<string> { "elma", "armut", "kiraz" };
foreach(var meyve in meyveler)
{
    Console.WriteLine(meyve);
}
//2
List<int> sayilar = new List<int> { 1, 2, 3, 4, 5 };
sayilar.Remove(3);
sayilar.Add(10);
foreach(var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
//3 ters çevir
sayilar.Reverse();
foreach(var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
//4 en büyük en küçük
int max = sayilar[0];
int min = sayilar[0];
for (int i = 1; i < sayilar.Count; i++)
{
    if (sayilar[i] > max)
    {
        max = sayilar[i];
    }
    if (sayilar[i] < min)
    {
        min = sayilar[i];
    }
}
Console.WriteLine("En buyuk sayi: " + max);
Console.WriteLine("En kucuk sayi " + min);