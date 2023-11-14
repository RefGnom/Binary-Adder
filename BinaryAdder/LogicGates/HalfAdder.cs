namespace BinaryAdder.LogicGates;

internal class HalfAdder
{
    public int InputA { get; set; }
    public int InputB { get; set; }

    public int OutputA => InputA ^ InputB;
    public int OutputB => InputA & InputB;

    public void Reset()
    {
        InputA = 0;
        InputB = 0;
    }
}