namespace StringCalculatorTDD;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter numbers to add: ");
        string numbers = "";

        while (true)
        {
            string line = Console.ReadLine();

            if (string.IsNullOrEmpty(line))
            {
                break;
            }

            numbers += line + "\n";
        }
        Console.WriteLine(numbers);
        int result = StringCalculator.Add(numbers);
        Console.WriteLine($"User entered numbers: {result}");
    }
}
