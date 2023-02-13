//public class Demo
//{
//    private int num;

//    public int Age
//    {
//        get { return num; }
//        set { num = value; }
//    }

//    public int Show()
//    {
//        return 0;
//    }
//}

public class Demo<T>
{
    T num;
    public void SetValue(T x)
    {
        this.num = x;
    }
    public T GetValue()
    {
        return this.num;
    }
}

class Sample<T, U>
{
    T x;
    U y;
}
public class Program
{
    public static void Main(string[] args)
    {
        Demo<int> demo = new Demo<int>();
        Demo<string> demo2 = new Demo<string>();

        Sample<int, string> sample = new Sample<int, string>();
        Sample<float, bool> sample2 = new Sample<float, bool>();

        demo.SetValue(10);
        demo2.SetValue("Hello");

        Console.WriteLine(demo.GetValue());
        Console.WriteLine(demo2.GetValue());
    }
}