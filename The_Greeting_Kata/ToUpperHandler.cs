using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Greeting_Kata;

public class ToUpperHandler : GreetingHandler
{
    public override string Greet(string name)
    {
        if (name == name.ToUpper())
        {
            return $"HELLO, {name}";
        }
        return _nextHandler?.Greet(name);
    }
}
