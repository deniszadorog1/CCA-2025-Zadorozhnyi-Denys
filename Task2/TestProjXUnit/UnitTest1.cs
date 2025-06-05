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
/*  
        [Fact]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            var calc = new Calculator();
            int result = calc.Add(-2, -3);
            Assert.Equal(-5, result);
        }*/
    }
}