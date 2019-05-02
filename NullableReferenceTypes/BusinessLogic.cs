using System;

namespace NullableReferenceTypes
{
    class BusinessLogic
    {
        public void Process(Entity entity)
        {
            if (int.TryParse(entity.Name, out var result))
            {
                Console.WriteLine(result * 100);
            }
            else
            {
                if (entity.Description.Length > 5)
                {
                    Console.WriteLine(entity.Description);
                }
                else
                {
                    var s = "'" + entity.Name + "'";

                    Console.WriteLine(s);
                }
            }
        }
    }
}
