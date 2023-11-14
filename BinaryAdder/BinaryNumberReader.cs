namespace BinaryAdder;

internal static class BinaryNumberReader
{
    public static BinaryNumber Read(string hint)
    {
        if (!string.IsNullOrEmpty(hint))
        {
            Console.WriteLine(hint);
        }
        return Read();
    }

    private static BinaryNumber Read()
    {
        Console.Write(">>> ");
        var token = Console.ReadLine();
        if (!BinaryNumber.IsCorrectInput(token))
        {
            Console.WriteLine($"Invalid value: {token}");
            return Read();
        }
        return new BinaryNumber(token);
    }
}