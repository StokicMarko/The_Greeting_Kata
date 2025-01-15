using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Greeting_Kata.Handlers;

public class ShoutingNameHandler : GreetingHandler
{
    public override string Handle(string[] names)
    {
        var shoutedNames = names.Where(name => name != null && name.All(char.IsUpper)).ToArray();
        if (shoutedNames.Length > 0)
        {
            return $"HELLO {string.Join(" AND ", shoutedNames)}!";
        }
        return _nextHandler?.Handle(names);
    }
}
