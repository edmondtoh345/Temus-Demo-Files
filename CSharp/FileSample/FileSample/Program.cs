namespace FileSample
{
    class Note
    {
        public Note()
        {
            if (!Directory.Exists(".//notes"))
            {
                Directory.CreateDirectory(".//notes");
            }
        }
        public void WriteNote()
        {
            StreamWriter sw = new StreamWriter(".//notes//File1.txt");
            sw.WriteLine("Hello World");
            sw.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Note obj = new Note();
            obj.WriteNote();
        }
    }
}