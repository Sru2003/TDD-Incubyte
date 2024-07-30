namespace StringCalculator
{
    public class StringCalculator
    {
        internal object Add(string value)
        {
            if(String.IsNullOrEmpty(value))
                return 0;

            var result = value.Split(',')
            .Select(s => int.Parse(s))
            .Sum();
            return result;
        }
    }
}
