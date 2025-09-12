using System;

namespace st1
{
    struct Nokta
    {
        public int X;
        public int Y;
        public Nokta(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Yazdir()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Nokta n1 = new Nokta(10, 20);
            n1.Yazdir();
            //Kopyalama > value type olduuğu için ayrı kopya oluşur.
            Nokta n2 = n1;
            n2.X = 99;
            n1.Yazdir(); // hala 10, 20
            n2.Yazdir(); //99
            Point p1 = new Point(5, 10);
            p1.Print();
            Point p2 = p1;
            p2.X = 20;
            p1.Print();
            p2.Print();
        }
    }
}
