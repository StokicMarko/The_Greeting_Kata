using The_Greeting_Kata;

namespace The_Greeting_Kata_Test;

using The_Greeting_Kata.Handlers;
using The_Greeting_Kata.Services;
using Xunit;

public class GreetingTests
{
    private readonly GreetingService _greetingService;

    public GreetingTests()
    {
        var nullNameHandler = new NullNameHandler();
        var shoutingNameHandler = new ShoutingNameHandler();
        var simpleHandler = new NormalNameHandler();
        var mixedNameHandler = new MixedNameHandler();

        nullNameHandler.SetNextHandler(mixedNameHandler);
        mixedNameHandler.SetNextHandler(shoutingNameHandler);
        shoutingNameHandler.SetNextHandler(simpleHandler);

        _greetingService = new GreetingService(nullNameHandler);
    }

    [Fact]
    public void Greet_ShouldReturnHelloBob_WhenNameIsBob()
    {
        var result = _greetingService.Greet(["Bob"]);
        Assert.Equal("Hello, Bob.", result);
    }

    [Fact]
    public void Greet_ShouldReturnHelloMyFriend_WhenNameIsNull()
    {
        var result = _greetingService.Greet([null]);
        Assert.Equal("Hello, my friend.", result);
    }

    [Fact]
    public void Greet_ShouldReturnHELLOJERRY_WhenNameIsJERRY()
    {
        var result = _greetingService.Greet(["JERRY"]);
        Assert.Equal("HELLO JERRY!", result);
    }

    [Fact]
    public void Greet_ShouldReturnHelloJillAndJane_WhenNamesAreJillAndJane()
    {
        var result = _greetingService.Greet(["Jill", "Jane"]);
        Assert.Equal("Hello, Jill and Jane.", result);
    }

    [Fact]
    public void Greet_ShouldReturnHelloAmyBrianAndCharlotte_WhenNamesAreAmyBrianCharlotte()
    {
        var result = _greetingService.Greet(["Amy", "Brian", "Charlotte"]);
        Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
    }

    [Fact]
    public void Greet_ShouldReturnHelloAmyAndCharlotteAndHELLOBRIAN_WhenNamesAreAmyBRIANCharlotte()
    {
        var result = _greetingService.Greet(["Amy", "BRIAN", "Charlotte"]);
        Assert.Equal("Hello, Amy and Charlotte. HELLO BRIAN!", result);
    }

    [Fact]
    public void Greet_ShouldReturnHelloBobCharlieAndDianne_WhenNamesAreBobAndCharlieDianne()
    {
        var result = _greetingService.Greet(["Bob", "Charlie, Dianne"]);
        Assert.Equal("Hello, Bob, Charlie, and Dianne.", result);
    }

    [Fact]
    public void Greet_ShouldReturnHelloBobAndCharlieDianne_WhenNamesAreBobAndQuotedCharlieDianne()
    {
        var result = _greetingService.Greet(["Bob", "\"Charlie, Dianne\""]);
        Assert.Equal("Hello, Bob and Charlie, Dianne.", result);
    }
}
