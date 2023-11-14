namespace BinaryAdder;

internal static class BinaryNumberReader
{
    public static int Read()
    {
        Console.Write(">>> ");
        var token = Console.ReadLine();
        if (!IsCorrectInput(token))
        {
            Console.WriteLine($"Invalid value: {token}");
            return Read();
        }
        return int.Parse(token);
    }

    private static bool IsCorrectInput(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        foreach (var digit in input)
        {
            if (digit != '0' && digit != '1')
            {
                return false;
            }
        }
        return true;
    }
}