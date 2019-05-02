namespace CSharpEightFeatures
{
    interface IFormatter
    {
        string Format(int n)
        {
            return n.ToString("d");
        }
    }
}
