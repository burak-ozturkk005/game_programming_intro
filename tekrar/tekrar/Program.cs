namespace tekrar;

class Program
{
    static void Main(string[] args)
    {
        string num = "15";
        int temp = Convert.ToInt32(num);
        temp += 2;
        num = temp.ToString();
        Console.WriteLine(num);
        
        int sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}