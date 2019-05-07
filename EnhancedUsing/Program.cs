using System.IO;

namespace EnhancedUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/using
            // https://github.com/dotnet/csharplang/blob/master/meetings/2018/LDM-2018-07-09.md
            using (var stream = File.Create(Path.GetTempFileName()))
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    streamWriter.WriteLine("Hello world");
                    streamWriter.Close();
                }
            }
        }
    }
}
