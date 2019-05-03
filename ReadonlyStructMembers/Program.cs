namespace ReadonlyStructMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/dotnet/csharplang/issues/1710
            var v = new Vector2();

            var result1 = MyClass.ExistingBehavior(v);

            var result2 = MyClass.ReadonlyBehavior(v);
        }
    }
}
