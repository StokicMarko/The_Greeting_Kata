public class SimpleGreeting : GreetingHandler
{
    public override string Greet(string name)
    {
        if (!string.IsNullOrEmpty(name) && name == name.ToUpper())
        {
            return _nextHandler?.Greet(name) ?? $"Hello, {name}.";
        }
        else if (!string.IsNullOrEmpty(name))
        {
            return $"Hello, {name}.";
        }
        return _nextHandler?.Greet(name);
    }
}