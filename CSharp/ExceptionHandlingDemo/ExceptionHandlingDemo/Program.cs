namespace ExceptionHandlingDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y, z = 0;
            try
            {
                Console.WriteLine("Enter First Number");
                x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                y = Convert.ToInt16(Console.ReadLine());
                if (x < y)
                {
                    throw new SmallerValueException("First number cannot be smaller than second number");
                }
                z = x / y;
                Console.WriteLine($"The result is {z}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide any number by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (SmallerValueException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("System error");
            }
            finally
            {
                Console.WriteLine("End of Program");
            }

        }
    }
}