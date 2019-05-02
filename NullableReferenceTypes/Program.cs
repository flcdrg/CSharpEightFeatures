namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var bl = new BusinessLogic();

            bl.Process("1234");
            bl.Process("Adelaide");
            bl.Process(null);

            string s = null;

            var c = s[1];
        }
    }
}
