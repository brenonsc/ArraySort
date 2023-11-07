using System.Text;

namespace ArraySort.Util;

public class StringFormatter
{
    public static string AddSpaceBeforeUppercase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder result = new StringBuilder();
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                result.Append(' ');
            }
            result.Append(input[i]);
        }

        return result.ToString();
    }
}