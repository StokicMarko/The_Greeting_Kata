using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Greeting_Kata
{
    public class NullNameHandler : GreetingHandler
    {
        public override string Greet(string name) 
        { 
            if (string.IsNullOrEmpty(name)) 
            { 
                return "Hello, my friend."; 
            } 
            return _nextHandler?.Greet(name); 
        }
    }
}
