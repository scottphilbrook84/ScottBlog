using System;
using Xunit;

namespace ScottBlog.Tests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void ReturnFalseGivenValuesLessThan2(int value)
    {
        var result = _primeService.IsPrime(value);

        Assert.False(result, String.Format("{0} should not be prime", value));
    }
}
