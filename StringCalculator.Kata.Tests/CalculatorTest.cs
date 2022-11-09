using FluentAssertions;
using Xunit;

namespace StringCalculator.Kata.Tests;

public class CalculatorTest
{
    private readonly Calculator calculator;

    public CalculatorTest()
    {
        this.calculator = new Calculator();
    }
    

    [Fact(DisplayName = "Given an empty string, it returns 0")]
    public void ShouldReturnZero_GivenEmptyString()
    {
        this.calculator.Add(string.Empty).Should().Be(0);
    }


    [Theory(DisplayName = "Given only one number, it returns its value")]
    [InlineData("5", 5)]
    [InlineData("7", 7)]
    [InlineData("2", 2)]
    public void ShouldReturnNumber_GivenSingleNumber(string numbers, int number)
    {
        this.calculator.Add(numbers)
            .Should()
            .Be(number);
    }

    [Theory(DisplayName = "Given 2 numbers, it returns their sum")]
    [InlineData("1,2", 3)]
    [InlineData("3,4", 7)]
    public void ShouldReturnSum_Given2Numbers(string numbers, int result)
    {
        this.calculator.Add(numbers)
            .Should()
            .Be(result);
    }


}