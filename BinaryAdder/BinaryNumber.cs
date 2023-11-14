namespace BinaryAdder;

internal class BinaryNumber
{
    private readonly int[] bits;

    public string StringValue { get; private set; }
    public int Length => StringValue.Length;
    public bool IsCorrect { get; init; }

    public BinaryNumber(string value)
    {
        StringValue = value;
        IsCorrect = IsCorrectInput(value);

        bits = new int[Length];
        if (IsCorrect)
        {
            for (int i = 0; i < Length; i++)
            {
                bits[i] = value[i] == '1' ? 1 : 0;
            }
        }
    }

    public int this[int bit]
    {
        get
        {
            if (!IsCorrect)
            {
                throw new InvalidOperationException("number is invalid");
            }
            if (bit >= 0 && bit < Length)
            {
                return bits[^(bit + 1)];
            }
            return 0;
        }
    }

    public static bool IsCorrectInput(string? input)
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

    public static BinaryNumber? From10CC(string value)
    {
        if (int.TryParse(value, out var number))
        {
            return From10CC(number);
        }
        return null;
    }

    public static BinaryNumber From10CC(int value)
    {
        var digits = new Stack<int>();
        while (value > 0)
        {
            digits.Push(value & 1);
            value >>= 1;
        }
        var numberIn2CC = string.Join("", digits);
        return new BinaryNumber(numberIn2CC);
    }

    public override string ToString() => StringValue;
}