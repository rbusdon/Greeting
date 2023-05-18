using Greeting;

namespace TestProject1
{
    public class GreetingTest
    {
        private Greetings _sut;

        public GreetingTest()
        {
            _sut = new Greetings();
        }
        [Fact]
        public void SimpleGreet()
        {
            var result = _sut.Greet("Gino");
            Assert.Equal("Hello, Gino!", result);
        }
        [Fact]
        public void SimpleNullGreet()
        {
            var result = _sut.Greet(null);
            Assert.Equal("Hello, my friend!", result);
        }
    }
}