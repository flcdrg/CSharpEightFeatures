namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/nullable-reference-types
            var bl = new BusinessLogic();

            bl.Process(new Entity("5000", "Postcode"));
            bl.Process(null);
            bl.Process(new Entity("City", null));
        }
    }
}
