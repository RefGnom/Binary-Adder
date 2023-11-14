using BinaryAdder.LogicGates;

namespace BinaryAdder;

internal static class Adder
{
    public static BinaryNumber Add(BinaryNumber first, BinaryNumber second)
    {
        var bitCount = int.Max(first.Length, second.Length);
        var answer = new Stack<int>(bitCount + 1);

        var nextBit = 0;
        for (int i = 0; i < bitCount + 1; i++)
        {
            var adder = new FullAdder();
            adder.InputFromOtherAddder = nextBit;
            adder.InputA = first[i];
            adder.InputB = second[i];
            answer.Push(adder.CurrentOutput);
            nextBit = adder.NextOutput;
        }
        var answerIn2CC = string.Join("", answer);
        return new BinaryNumber(answerIn2CC);
    }
}