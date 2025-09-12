namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>(); // boş liste
            List<string> fruits = new List<string> { "apple", "banana", "orange", "banana", "graple" };
            Console.WriteLine("Before: ");

            foreach (string fruit in fruits)
            {
                Console.Write(fruit + " "); 
            }
            Console.WriteLine("eleman sayisi:  " + fruits.Count); // 5
            fruits.Remove("banana"); // bahsi geçen elemanı siler.

            fruits.Clear(); //bütün elemanları siler.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            numbers.Insert(3, 8);
            foreach(int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine(numbers.Capacity); // kapasiteyi 2 katına çıkarır.
            numbers.Sort();
            numbers.Sort((a,b) => b - a); // büyükten küçüğe sıralama
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }
            
        }
    }
}
