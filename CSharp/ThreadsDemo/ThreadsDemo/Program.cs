namespace ThreadsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
            int i = 1;
            Task.Factory.StartNew(new Action(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Task.Delay(500).Wait();
                    Console.WriteLine(i);
                    i++;
                }
            }));
            //t.Start();
            Console.ReadLine();
            source.Cancel();
        }
    }
}