namespace ReadonlyStructMembers
{
    public static class MyClass
    {
        public static float ExistingBehavior(in Vector2 vector)
        {
            // This code causes a hidden copy, the compiler effectively emits:
            //    var tmpVector = vector;
            //    return tmpVector.GetLength();
            //
            // This is done because the compiler doesn't know that `GetLength()`
            // won't mutate `vector`.

            return vector.GetLength();
        }

        public static float ReadonlyBehavior(in Vector2 vector)
        {
            // This code is emitted exactly as listed. There are no hidden
            // copies as the `readonly` modifier indicates that the method
            // won't mutate `vector`.

            return vector.GetLengthReadonly();
        }
    }
}
