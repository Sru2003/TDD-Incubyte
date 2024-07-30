namespace StringCalculator
{
    public class StringCalculator_Add
    {
        [Fact]
        public void Returns0WhenEmptyString()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void Returns1WhenEmptyString(String value,int expectedValue)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(value);

            Assert.Equal(expectedValue, result);
        }
    }
}