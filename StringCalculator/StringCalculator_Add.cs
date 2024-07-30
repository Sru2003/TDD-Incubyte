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
    }
}