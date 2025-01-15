namespace The_Greeting_Kata_Test.HandlersTest;
using Xunit;

public class NormalNameHandlerTests
{
    private readonly NormalNameHandler handler;
    public NormalNameHandlerTests()
    {
        handler = new NormalNameHandler();
    }

    [Fact]
    public void Should_Return_HelloWithSingleName_When_SingleNameInput()
    {
        var names = new string[] { "John" };
        var result = handler.Handle(names);

        Assert.Equal("Hello, John.", result);
    }

    [Fact]
    public void Should_Return_HelloWithTwoNames_When_TwoNamesInput()
    {
        var names = new string[] { "John", "Doe" };
        var result = handler.Handle(names);

        Assert.Equal("Hello, John and Doe.", result);
    }

    [Fact]
    public void Should_Return_HelloWithAllNames_When_MultipleNamesInput()
    {
        var names = new string[] { "John", "Doe", "Smith" };
        var result = handler.Handle(names);

        Assert.Equal("Hello, John, Doe, and Smith.", result);
    }
}

