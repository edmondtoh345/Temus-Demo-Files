class Calculator
{
    public void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}
class Program
{
    public static void Main()
    {
        //Calculator calc = new Calculator();
        //calc.Sum(10, 20);
        //Calculator.Subtract(30, 20);
        long num = 1234;
        int num2 = (int)num;
        Console.WriteLine(num2);

        int x = 10;
        string s = Convert.ToString(x);
    }
}