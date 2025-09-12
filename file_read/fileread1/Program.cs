using System;
using System.IO;
namespace fileread1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dosya yoksa oluşturur, varsa üzerine yazar.
            using (StreamReader sr = new StreamReader("./deneme.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            using (StreamWriter sw = new StreamWriter("deneme.txt"))
            {
                sw.WriteLine("Merhaba Burak");
                sw.WriteLine("StreamWriter ile yazıyoruz.");
            }
            Console.WriteLine("Dosya yazıldı.");
            //Append üzerine ekleme yöntemi
            using (StreamWriter sw = new StreamWriter("deneme.txt", true))
            {
                sw.WriteLine("Bu satır en sona eklenecek.");
            }

        }
    }
}
