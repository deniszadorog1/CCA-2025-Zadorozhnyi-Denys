using Task2Lib;
namespace TestProjXUnit
{
    public class UnitTest1
    {
      [Fact]
        public void Test1()
        {
            var calculator = new Calculator();
            var result = calculator.Addition(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void AbstractTest()
        {
            var calc = new Calculator();
            int result = calc.Minus(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MultiplicationTest()
        {
            var calc = new Calculator();
            int result = calc.Minus(2, 3);
            Assert.Equal(6, result);
        }
    }
}