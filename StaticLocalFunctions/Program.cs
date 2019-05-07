using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/dotnet/csharplang/issues/1565
            static void LocalFunction()
            {
                Console.WriteLine("Hello World!");
            }

            LocalFunction();
        }
    }
}
