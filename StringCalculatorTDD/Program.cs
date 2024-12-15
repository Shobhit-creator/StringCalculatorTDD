namespace StringCalculatorTDD;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter numbers to add: ");

        string numbers = Console.ReadLine();

        int result = StringCalculator.Add(numbers);
        Console.WriteLine($"User entered numbers: {result}");
    }
}
