namespace temel;

class Program
{
    static void Main(string[] args)
    {
       
        //Diziler
        int[] sayilar = [1, 2, 3, 4, 5];
        Console.WriteLine(sayilar[2]);
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine(sayilar[i]);
        }
        
        
    }
}