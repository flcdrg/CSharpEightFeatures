namespace CSharpEightFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new BusinessLogic(new FunnyFormatter());

            b.Process();
        }
    }
}
