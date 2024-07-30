namespace StringCalculator
{
   
    public class StringCalculator_Add
    {
        [Fact]
        public void Returns0WhenEmptyStringGiven()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnsNumberWhen1NumberGiven(String value,int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("3,2", 5)]
        public void ReturnsSumWhen2NumbersGiven(String value, int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("1,2,3,4,5,6", 21)]
        public void ReturnsSumWhen6NumbersGiven(String value, int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("1,\n2,3,4,5,6", 21)]
        [InlineData("2,\n\n2,\n3",7)]
        public void ReturnsSumIgnoringNewline(String value, int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        public void ReturnsSumIgnoringCustomDelimitors(String value, int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("-3,4", "Negative numbers are not allowed: -3")]
        [InlineData("-1,-2", "Negative numbers are not allowed: -1, -2")]
        public void ThrowsNegativeNumberException(string value, string expectedValue)
        {
            var calculator = new StringCalculator();

            var exception = Assert.Throws<NegativeNumberException>(() => calculator.Add(value));

            Assert.Equal(expectedValue, exception.Message);
        }

        [Fact]
        public void Returns0WhenGetCalledCountInitially()
        {
            var calculator = new StringCalculator();

            var count = calculator.GetCalledCount();

            Assert.Equal(0, count);
        }


        [Fact]
        public void ReturnsCorrectCountAfterAddCalled()
        {
            var calculator = new StringCalculator();

            calculator.Add("1,2");
            calculator.Add("3,4");

            var count = calculator.GetCalledCount();

            Assert.Equal(2, count);
        }

    }
}