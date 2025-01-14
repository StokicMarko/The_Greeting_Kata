namespace The_Greeting_Kata_Test
{
    public class UnitTest1
    {
        private readonly GreetingHandler simple;

        public UnitTest1()
        {
            simple = new SimpleGreeting();
        }
        [Fact]
        public void Should_Return_Specific_Greet_When_Input_Name()
        {
            Assert.Equal("Hello, Mario.", simple.Greet("Mario"));
        }
    }
}