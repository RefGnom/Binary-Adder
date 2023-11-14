using BinaryAdder;

internal class Program
{
    private static void Main()
    {
        var firstNumber = BinaryNumberReader.Read("Enter first number");
        var secondNumber = BinaryNumberReader.Read("Enter second number");

        var bitCount = int.Max(firstNumber.Length, secondNumber.Length);
        var answer = new int[bitCount + 1];

        var nextBit = 0;
        for (int i = 0; i < bitCount + 1; i++)
        {
            var adder = new FullAdder();
            adder.InputFromOtherAddder = nextBit;
            adder.InputA = firstNumber[i];
            adder.InputB = secondNumber[i];
            answer[i] = adder.CurrentOutput;
            nextBit = adder.NextOutput;
        }

        Console.WriteLine(string.Join("", answer.Reverse()));
    }
}