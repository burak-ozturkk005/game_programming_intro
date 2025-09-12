using System;
using System.Collections.Generic;
//Dictionary nedir > Anahtar(key) değer(value) çiftlerini tutar.
//Listten farkı : List sıraya göre çalışır. Dictionar de ise anahtar üzerinden direk erişim vardır.
//Key benzersizdir.
Dictionary<string, string> ulkeler = new Dictionary<string, string>();
ulkeler.Add("Turkiye", "Ankara");
ulkeler.Add("Almanya", "Berlin");
ulkeler.Add("Japonya", "Tokyo");
Console.WriteLine(ulkeler["Turkiye"]);

foreach(var item in ulkeler)
{
    Console.WriteLine(item.Key + " > " + item.Value);
}

Dictionary<int, string> sayilar = new Dictionary<int, string>();
sayilar.Add(1, "bir");
sayilar.Add(2, "iki");
sayilar.Add(3, "üç");
sayilar.Remove(2);
foreach(var item in sayilar)
{
    Console.WriteLine(item.Key + " > " + item.Value);
}
//Soru 
Dictionary<string, int> soru = new Dictionary<string, int>();
soru.Add("elma", 5);
soru.Add("armut", 3);
Console.Write("Meyve gir: ");
string input = Console.ReadLine();
bool bulundu = false;
foreach (var item in soru)
{
    if(item.Key == input)
    {
        Console.WriteLine(item.Value);
        bulundu = true;
    }
    if(!bulundu)
    {
        Console.WriteLine("bulunamadı");
    }
}