using System;

namespace ReadonlyStructMembers
{
    public struct Vector2
    {
        public float x;
        public float y;

        public readonly float GetLengthReadonly()
        {
            return MathF.Sqrt(LengthSquared);
        }

        public float GetLength()
        {
            return MathF.Sqrt(LengthSquared);
        }

        public readonly float GetLengthIllegal()
        {
            var tmp = MathF.Sqrt(LengthSquared);

            x = tmp;    // Compiler error, cannot write x
            y = tmp;    // Compiler error, cannot write y

            return tmp;
        }

        public readonly float LengthSquared
        {
            get
            {
                return (x * x) +
                       (y * y);
            }
        }
    }
}
