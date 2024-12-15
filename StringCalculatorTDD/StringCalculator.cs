namespace StringCalculatorTDD;
public static class StringCalculator
{
    public static int Add(string numbers)
    {
        if(numbers.Length == 0) return 0;
        char[] chars = numbers.ToCharArray();
        int sum = 0;
        foreach(char ch in chars)
        {
            if(ch >= '0' && ch <= '9')
            {
                sum += ch - '0';
            }
        }
        return sum;
    }
}