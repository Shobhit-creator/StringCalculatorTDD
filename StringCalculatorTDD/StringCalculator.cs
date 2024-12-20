using System.Text.RegularExpressions;

namespace StringCalculatorTDD;
public static class StringCalculator
{
    public static int Add(string numbers)
    {
        int n = numbers.Length;
        if(numbers.Length == 0) return 0;

        int sum = 0;
        string pattern = @"^//(.+)\n([\s\S]*)$";

        Match match = Regex.Match(numbers, pattern);
        string[] delimiters = new string[2];
        delimiters[0] = "\n";
        if(match.Success)
        {
            string delimiter = match.Groups[1].Value; 
            numbers = match.Groups[2].Value;

            delimiters[1] = delimiter;
        }else
        {
            delimiters[1] = ",";
        }
        string[] numbersArray = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        List<int> negativeNumbers = new List<int>();
        foreach (string number in numbersArray)
        {
            if(int.TryParse(number, out int integer))
            {
                if(integer < 0)
                {
                    negativeNumbers.Add(integer);
                }
                else
                {
                    sum += integer;
                }
            }
        }
        if(negativeNumbers.Count > 0)
        {
            throw new ArgumentException($"Negative numbers are not allowed: {string.Join(",", negativeNumbers)}");
        }
        return sum;
    }
}