namespace StringCalculatorTDD;
public static class StringCalculator
{
    public static int Add(string numbers)
    {
        int n = numbers.Length;
        if(numbers.Length == 0) return 0;
        char[] chars = numbers.ToCharArray();
        int sum = 0, i= 0, num = 0;
        while(i < n)
        {
            if(chars[i] == ',' || chars[i] == '\n')
            {
                sum += num;
                num = 0;
            }
            else if (chars[i] == '\\' && i + 1 < n && chars[i + 1] == 'n')
            {
                sum += num;
                num = 0;   
                i++;         
            }
            else if(chars[i] >= '0' && chars[i] <= '9')
            {
                num = chars[i] - '0' + num * 10;
            }
            i += 1;
        }
        sum += num;
        return sum;
    }
}