using The_Greeting_Kata.Handlers;

namespace The_Greeting_Kata_Test.HandlersTest;

public class NullNameHandlerTest
{
    private readonly NullNameHandler nullNameHandler;

    public NullNameHandlerTest()
    {
        nullNameHandler = new NullNameHandler();
    }

    [Fact]
    public void Should_Return_HelloMyFriend_When_Name_Is_Null()
    {
        Assert.Equal("Hello, my friend.", nullNameHandler.Handle(null));
    }
}
