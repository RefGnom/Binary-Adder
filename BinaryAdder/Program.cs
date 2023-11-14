using BinaryAdder;

internal class Program
{
    private static void Main()
    {
        var loop = new Loop();
        loop.OnLoop += () =>
        {
            var firstToken = Reader.Read("Enter first number", x => int.TryParse(x, out _));
            var secondToken = Reader.Read("Enter second number", x => int.TryParse(x, out _));

            var firstNumber = BinaryNumber.From10CC(firstToken);
            var secondNumber = BinaryNumber.From10CC(secondToken);

            var result = Adder.Add(firstNumber, secondNumber);

            Console.WriteLine(result.ConvertTo10CC());
        };

        loop.Start();
    }
}