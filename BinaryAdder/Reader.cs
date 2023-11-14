namespace BinaryAdder;

internal static class Reader
{
    public static string Read(string hint, Func<string, bool> isValid)
    {
        if (!string.IsNullOrEmpty(hint))
        {
            Console.WriteLine(hint);
        }
        return Read(isValid);
    }

    private static string Read(Func<string, bool> isValid)
    {
        Console.Write(">>> ");
        var token = Console.ReadLine();
        if (!isValid(token))
        {
            Console.WriteLine($"Invalid value: {token}");
            return Read(isValid);
        }
        return token;
    }
}