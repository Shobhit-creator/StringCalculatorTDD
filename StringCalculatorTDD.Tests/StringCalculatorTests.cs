using Xunit;

namespace StringCalculatorTDD.Tests;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyString_NoNumbersToAdd_ShouldReturnZero()
    {
        string str = "";

        int result = StringCalculator.Add(str);

        Assert.Equal(result, 0);
    }
}