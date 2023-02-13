namespace DependencyDemo.Repository
{
    public class Generator : IGenerator
    {
        Guid guid;
        public Generator()
        {
            guid = Guid.NewGuid();
        }
        public string GetID()
        {
            return guid.ToString();
        }
    }
}
