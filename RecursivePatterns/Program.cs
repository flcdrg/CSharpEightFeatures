using System;

namespace RecursivePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://msdn.microsoft.com/en-us/magazine/mt833440.aspx
            // https://github.com/dotnet/csharplang/blob/master/proposals/csharp-8.0/patterns.md
            var shape = new Rectangle();

            var result = shape switch
            {
                { Point: { Y: 100 } } => "Y is 100",
                { Point: null } => "Point not initialized",
                _ => "Something else"
            };

            Console.WriteLine(result);
        }
    }
}
