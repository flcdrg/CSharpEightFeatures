using System;

namespace CSharpEightFeatures
{
    class BusinessLogic
    {
        private readonly IFormatter _formatter;

        public BusinessLogic(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public void Process()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(_formatter.Format(i));

            }

        }
    }
}
