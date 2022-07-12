using NumberingConsoleApp.CheckDigitVerifier;

namespace NumberingConsoleApp.Tests
{
    public class MOD97CalculatorTest
    {
        [Fact]
        public void MOD97CalculatorTests()
        {
            //Arrange
            int value1 = 1000;
            int value2 = 26876;
            int value3 = 123456789;
            int value4 = 9700;
            //Act
            string mod97Result01 = CheckDigitVerifier.MOD97Calculator.MOD97Calculation(value1);
            string mod97Result02 = CheckDigitVerifier.MOD97Calculator.MOD97Calculation(value2);
            string mod97Result03 = CheckDigitVerifier.MOD97Calculator.MOD97Calculation(value3);
            string mod97Result04 = CheckDigitVerifier.MOD97Calculator.MOD97Calculation(value4);

            //Assert

            Assert.Equal("30", mod97Result01);
            Assert.Equal("07", mod97Result02);
            Assert.Equal("39", mod97Result03);
            Assert.Equal("00", mod97Result04);
        }
    }
}