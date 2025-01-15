namespace The_Greeting_Kata_Test.HandlersTest;
using The_Greeting_Kata.Handlers;
using Xunit;
public class MixedNameHandlerTests
{
    private readonly MixedNameHandler _handler;
    public MixedNameHandlerTests()
    {
        _handler = new MixedNameHandler();
    }

    [Fact]
    public void Should_Return_HelloWithSingleNormalName_When_SingleNormalNameInput()
    {
        var names = new string[] { "John" };
        var result = _handler.Handle(names);

        Assert.Equal("Hello, John.", result);
    }

    [Fact]
    public void Should_Return_HelloWithTwoNormalNames_When_TwoNormalNamesInput()
    {
        var names = new string[] { "John", "Doe" };
        var result = _handler.Handle(names);

        Assert.Equal("Hello, John and Doe.", result);
    }

    [Fact]
    public void Should_Return_HelloWithAllNormalNames_When_MultipleNormalNamesInput()
    {
        var names = new string[] { "John", "Doe", "Smith" };
        var result = _handler.Handle(names);

        Assert.Equal("Hello, John, Doe, and Smith.", result);
    }

    [Fact]
    public void Should_Return_HelloWithShoutedNames_When_ShoutedNamesInput()
    {
        var names = new string[] { "JOHN", "DOE" };
        var result = _handler.Handle(names);

        Assert.Equal("HELLO JOHN AND DOE!", result);
    }

    [Fact]
    public void Should_Return_BothGreetings_When_MixedNamesInput()
    {
        var names = new string[] { "John", "DOE" };
        var result = _handler.Handle(names);

        Assert.Equal("Hello, John. HELLO DOE!", result);
    }

    [Fact]
    public void Should_HandleNamesWithEscapedCommas()
    {
        var names = new string[] { "\"John Doe\"", "Smith" };
        var result = _handler.Handle(names);

        Assert.Equal("Hello, John Doe and Smith.", result);
    }

    [Fact]
    public void Should_HandleNamesWithCommas()
    {
        var names = new string[] { "John, Doe", "Smith" };
        var result = _handler.Handle(names);

        Assert.Equal("Hello, John, Doe, and Smith.", result);
    }
}