using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Greeting_Kata.Handlers;

namespace The_Greeting_Kata_Test.HandlersTest;

public class ShoutingNameHandlerTest
{
    private readonly ShoutingNameHandler shoutingNameHandler;

    public ShoutingNameHandlerTest()
    {
        shoutingNameHandler = new ShoutingNameHandler();
    }

    [Fact]
    public void Should_Return_HELLOBOB_When_Input_Is_BOB()
    {
        Assert.Equal("HELLO BOB!", shoutingNameHandler.Handle(["BOB"]));
    }
}
