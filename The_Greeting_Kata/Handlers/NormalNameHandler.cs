public class NormalNameHandler : GreetingHandler 
{ 
    public override string Handle(string[] names) 
    { 
        var normalNames = names.Where(name => name != null && !name.All(char.IsUpper)).ToArray(); 
        if (normalNames.Length > 0) 
        {
            if (normalNames.Length == 1) 
            { 
                return $"Hello, {normalNames[0]}."; 
            } 
            else if (normalNames.Length == 2) 
            { 
                return $"Hello, {normalNames[0]} and {normalNames[1]}."; 
            } 
            else 
            { 
                return $"Hello, {string.Join(", ", normalNames.Take(normalNames.Length - 1))}, and {normalNames.Last()}."; 
            } 
        } 
        return _nextHandler?.Handle(names); 
    } 
}

