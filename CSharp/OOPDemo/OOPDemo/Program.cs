
public class Program
{
    public static void Main(string[] args)
    {
        int age = 25;
        string name = "John";
        string city = "New Delhi";

        Console.WriteLine("Hi " + name + " you are " + age + " years old. You live in " + city);
        Console.WriteLine($"Hi {name} you are {age} years old. You live in {city}");

    }
}