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
        public void ReturnsNumberWhen2NumbersGiven(String value, int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }
    }
}