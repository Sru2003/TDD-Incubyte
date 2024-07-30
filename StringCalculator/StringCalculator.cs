using System.Text.RegularExpressions;

namespace StringCalculator
{
    public class StringCalculator
    {
        internal object Add(string value)
        {
            if(String.IsNullOrEmpty(value))
                return 0;
            

            if(value.StartsWith("//"))
            {
      

                value = Regex.Replace(value, "//(.*?)\n"
, "");

            }
            value = value.Replace(";", ",");
            value = value.Replace("\n", "");
            var result = value.Split(',')
            .Select(s => int.Parse(s))
            .Sum();
            return result;
        }
    }
}
