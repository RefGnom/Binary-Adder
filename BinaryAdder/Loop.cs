namespace BinaryAdder;

internal class Loop
{
    public event Action? OnLoop;

    public void Start()
    {
        while (true)
        {
            OnLoop?.Invoke();
        }
    }
}