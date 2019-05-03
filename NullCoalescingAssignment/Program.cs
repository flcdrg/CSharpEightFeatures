using System;

namespace NullCoalescingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/dotnet/csharplang/blob/master/proposals/csharp-8.0/null-coalescing-assignment.md

            string y = null;

            if (y == null)
            {
                y = "def";
            }

            #region Assignment
            // y ??= "def";
            #endregion

            Console.WriteLine(y);
        }
    }
}
