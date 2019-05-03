using System;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/dotnet/csharplang/blob/master/proposals/csharp-8.0/ranges.md
            const string name = "Adelaide .NET User Group";

            var location = name.Substring(0, 8);
            var kind = name.Substring(name.Length - 5, 5);

            // var index = ^5;
            // var range = 3..4;

            Console.WriteLine(location);
            Console.WriteLine(kind);
        }
    }
}
