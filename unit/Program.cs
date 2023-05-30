namespace unit;
class Program
{
    public static int Topla(int num1,int num2)
    {
        return num1 + num2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Topla(2, 3)); 
        Console.ReadKey();
    }
}