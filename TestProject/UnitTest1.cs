using TestUnit;

namespace TestProject
{
    public class UnitTest1
    {
        private readonly Calculator _calculator;

        public UnitTest1()
        {
            _calculator = new Calculator();
        }

        // Test for Addition
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -2, -3)]
        public void Add_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        // Test for Subtraction
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(0, 5, -5)]
        public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        // Test for Multiplication
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 5, 0)]
        public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
        {
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        // Test for Division
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void Divide_ReturnsCorrectQuotient(int a, int b, double expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        // Test for Division by Zero
        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
