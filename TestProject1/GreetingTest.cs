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
            string[] name = { "Gino" };
            string[] result = { _sut.Greet(name) };
            string expected = "Hello, Gino!";
            Assert.Equal(expected, result[0]);
        }
        [Fact]
        public void SimpleNullGreet()
        {
            string[] name = null;
            string[] result = { _sut.Greet(name) };
            string expected = "Hello, my friend!";
            Assert.Equal(expected, result[0]);
        }
        [Fact]
        public void ShoutingGreet()
        {
            string[] name = { "JERRY" };
            string[] result = { _sut.Greet(name) };
            string expected = "HELLO JERRY!";
            Assert.Equal(expected, result[0]);
        }
        [Fact]
        public void GroupOfTwoGreet()
        {
            string[] name = { "Jill", "Jane" };
            string[] result = { _sut.Greet(name) };
            string expected = "Hello, Jill and Jane!";
            Assert.Equal(expected, result[0]);
        }
        [Fact]
        public void GroupGreet()
        {
            string[] name = { "Qui", "Quo", "Qua", "Tip", "Tap" };
            string[] result = { _sut.Greet(name) };
            string expected = "Hello, Qui, Quo, Qua, Tip and Tap!";
            Assert.Equal(expected, result[0]);
        }
        [Fact]
        public void MixedGreet()
        {
            string[] name = { "Qui", "QUO", "Qua", "TIP", "Tap" };
            string[] result = { _sut.Greet(name) };
            string expected = "Hello, Qui, Qua and Tap! AND HELLO QUO AND TIP!";
            Assert.Equal(expected, result[0]);
        }
    }
}