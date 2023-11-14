namespace BinaryAdder;

internal class FullAdder
{
    private readonly HalfAdder fromInputs = new();
    private readonly HalfAdder fromOtherAdder = new();

    public int InputA
    {
        set
        {
            fromInputs.InputA = value;
            fromOtherAdder.InputB = fromInputs.OutputA;
        }

    }
    public int InputB
    {
        set
        {
            fromInputs.InputB = value;
            fromOtherAdder.InputB = fromInputs.OutputA;
        }
    }

    public int InputFromOtherAddder
    {
        set
        {
            fromOtherAdder.InputA = value;
        }
    }

    public int CurrentOutput => fromOtherAdder.OutputA;
    public int NextOutput => fromInputs.OutputB | fromOtherAdder.OutputB;

    public void Reset()
    {
        InputA = 0;
        InputB = 0;
        InputFromOtherAddder = 0;
    }
}