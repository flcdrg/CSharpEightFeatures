using System;

namespace InterpolatedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verbatim interpolated strings
            // https://github.com/dotnet/csharplang/issues/1630

            Console.WriteLine(@$"Hello World {DateTime.Now}");
            Console.WriteLine($@"Hello World {DateTime.Now}");
        }
    }
}
