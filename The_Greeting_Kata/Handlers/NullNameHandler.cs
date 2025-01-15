namespace The_Greeting_Kata.Handlers;

public class NullNameHandler : GreetingHandler
{
    public override string Handle(string[] names)
    {
        if (names == null || names.Length == 0 || names[0] == null)
        {
            return "Hello, my friend.";
        }
        return _nextHandler?.Handle(names);
    }
}
