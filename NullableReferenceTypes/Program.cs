namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var bl = new BusinessLogic();

            bl.Process(new Entity("5000", "Postcode"));
            bl.Process(null);
            bl.Process(new Entity("City", null));
        }
    }
}
