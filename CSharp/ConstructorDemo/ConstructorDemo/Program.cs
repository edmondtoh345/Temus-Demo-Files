abstract class Class1
{
    public abstract void Sum(int x, int y);

    public abstract void Multiply(int x, int y);

    public void Subtract(int x, int y)
    {
        Console.WriteLine(x - y);
    }
}

class Calculator: Class1
{
    public override void Sum(int x, int y)
    {
        Console.WriteLine(x + y);
    }

    public override void Multiply(int x, int y)
    {
        Console.WriteLine(x * y);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        
    }
}