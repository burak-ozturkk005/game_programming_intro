namespace dictionaries;

class Program
{
    static void Main(string[] args)
    {
        //Sözlükler
        var envanter = new Dictionary<string, int>();

        var puan = new Dictionary<string, int>()
        {
            ["Burak"] = 10,
            ["Ayşe"] = 15
        };
        //Ekle / Güncelle / Oku
        envanter.Add("Potion",3);
        envanter["Potion"] = 5;
        bool varMi = envanter.ContainsKey("Potion");
        int adet = envanter["Potion"];
        foreach (var i in envanter)
        {
            Console.WriteLine(i);
        }
        
    }
}