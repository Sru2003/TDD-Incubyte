using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class StringCalculator
    {
        internal object Add(string value)
        {
            if(String.IsNullOrEmpty(value))
                return 0;


            if (value.StartsWith("//"))
            {
      

                value = Regex.Replace(value, "//(.*?)\n"
, "");

            }

            value = value.Replace(";", ",");
            value = value.Replace("\n", "");

            var numberList = value.Split(',')
            .Select(s => int.Parse(s))
            .ToList();
            var negatives = numberList.Where(n => n < 0).ToList();
            if (negatives.Any())
            {
                throw new NegativeNumberException("Negative numbers are not allowed: " + string.Join(", ", negatives));
            }
            var result=numberList.Sum();
            return result;
        }
    }

    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }
}
