public abstract class GreetingHandler
{
    protected GreetingHandler _nextHandler;

    public void SetNextHandler(GreetingHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract string Handle(string[] names);
}

