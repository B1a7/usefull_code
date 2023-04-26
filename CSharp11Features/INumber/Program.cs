using System.Numerics;


int [] ints = new int[] {1, 2, 4};

var sum = AddAll(ints);


T AddAll<T>(T[] values) where T : INumber<T> 
{
    T result = T.Zero;

    foreach ( var value in values)
        result += value;
    return result;
}