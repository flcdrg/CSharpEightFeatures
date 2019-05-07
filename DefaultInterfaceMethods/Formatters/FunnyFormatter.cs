namespace CSharpEightFeatures
{
    class FunnyFormatter : IFormatter
    {
        public string Format(int n)
        {
            return $"ha {n} ha";
        }
    }
}
