using System;

namespace NullableReferenceTypes
{
    class BusinessLogic
    {
        public void Process(string text)
        {
            if (int.TryParse(text, out var result))
            {
                Console.WriteLine(result * 100);
            }
            else
            {
                if (text.Length > 5)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    var s = "'" + text + "'";

                    Console.WriteLine(s);
                }
            }
        }
    }
}
