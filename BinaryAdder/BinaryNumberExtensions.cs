namespace BinaryAdder;

internal static class BinaryNumberExtensions
{
    public static int ConvertTo10CC(this BinaryNumber number)
    {
        if (!number.IsCorrect)
        {
            throw new InvalidOperationException("number is invalid");
        }
        var coeff = 1;
        var result = 0;
        for (var i = 0; i < number.Length; i++)
        {
            result += number[i] * coeff;
            coeff <<= 1;
        }
        return result;
    }
}