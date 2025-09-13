using System;
using System.Collections.Generic;
Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

ogrenciler.Add(1, "Ismet");
ogrenciler.Add(2, "Johny");
ogrenciler.Add(3, "Burak");
ogrenciler[4] = "Kemal"; //farklı şekilde ekleme

if(ogrenciler.ContainsKey(1))
{
    Console.WriteLine("1 numaralı ogrenci var.");
}
foreach(var item in ogrenciler)
{
    Console.WriteLine($"Key: {item.Key},Value: {item.Value}");
}
//Example
string[] isimler = { "İstanbul", "Ankara", "Bursa" };
string[] plakalar = { "34", "06", "16" };
Dictionary<string, string> sehirler = new Dictionary<string, string>();
for(int i = 0;i < isimler.Length;i++)
{
    sehirler[plakalar[i]] = isimler[i];
}
foreach(var item in sehirler)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
Console.WriteLine(sehirler.ContainsKey("06"));
