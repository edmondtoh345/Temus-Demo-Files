namespace DelegateDemo
{
    public class Demo
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Func<int, int, int> f = d.Sum;
            int result = f(10, 20);
            Console.WriteLine(result);
        }
    }
}