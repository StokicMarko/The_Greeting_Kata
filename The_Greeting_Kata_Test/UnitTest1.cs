using The_Greeting_Kata;

namespace The_Greeting_Kata_Test
{
    public class UnitTest1
    {
        private readonly GreetingHandler simpleGreet;
        private readonly GreetingHandler nullGreet;
        private readonly GreetingHandler upper;

        public UnitTest1()
        {
            simpleGreet = new SimpleGreeting();
            nullGreet = new NullNameHandler();
            upper = new ToUpperHandler();
        }
        [Fact]
        public void Should_Return_Specific_Greet_When_Input_Name()
        {
            Assert.Equal("Hello, Mario.", simpleGreet.Greet("Mario"));
        }
        [Fact]
        public void Should_Return_Specific_Greet_When_Input_Null()
        {
            Assert.Equal("Hello, my friend.", nullGreet.Greet(null));
        }
        [Fact]
        public void Should_Return_TOUPPER_When_INPUT_IS_TOUPPER()
        {
            Assert.Equal("HELLO, MARIO", upper.Greet("MARIO"));
        }
    }
}