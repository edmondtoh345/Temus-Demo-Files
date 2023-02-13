//Method declaration with void
void SayHello()
{
    Console.WriteLine("Hello");
}

void SayHello2(string name)
{
    Console.WriteLine("Hello " + name);
}

int Cube(int x)
{
    return x * x * x;
}

int Sum(int x, int y)
{
    return x + y;
}

int ProcessString(string str)
{
    return str.Length;
}



int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <=num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

Console.WriteLine("Enter Any Number");
int val = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Factorial(val));


//int total = Sum(10, 20);
//Console.WriteLine(total);

//int result = Cube(5);
//Console.WriteLine(result);


//SayHello(); // Calling Statement
//SayHello2("John");