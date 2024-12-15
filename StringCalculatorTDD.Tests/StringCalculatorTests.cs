using Xunit;

namespace StringCalculatorTDD.Tests;

public class StringCalculatorTests
{

    [Theory]
    [InlineData("", 0)]
    [InlineData("2", 2)]
    [InlineData("2,3,5,7", 17)]
    public void NumberString_ValidInput_ShouldReturnSum(string input, int expectedResult)
    {
        int result = StringCalculator.Add(input);

        Assert.Equal(result, expectedResult);
    }
}