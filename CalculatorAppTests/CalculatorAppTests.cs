using CalculatorAPP;

namespace CalculatorAppTests
{
    public class CalculatorAppTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(5, 3);
            Assert.Equal(8, result);
        }
    }
}
