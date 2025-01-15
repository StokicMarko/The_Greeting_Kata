using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Greeting_Kata;

public class GreetingService
{
    private readonly GreetingHandler handler;

    public GreetingService(GreetingHandler handler)
    {
        this.handler = handler;
    }

    public string Greet(string[] names)
    {
        return handler.Handle(names);
    }
}
