using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreams
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // https://github.com/dotnet/csharplang/blob/master/proposals/csharp-8.0/async-streams.md
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/generate-consume-asynchronous-stream

            await foreach (var s in GetTextAsync())
            {
                Console.WriteLine(s);
            }
        }

        private static async IAsyncEnumerable<string> GetTextAsync()
        {
            var lines = await File.ReadAllLinesAsync(@"c:\tmp\freshbing.ps1");
            foreach (var line in lines)
            {
                yield return line;
            }
        }
    }
}
