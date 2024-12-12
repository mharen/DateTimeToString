namespace Tests;

public class ExtensionsTests
{
    [Theory]
    [InlineData("2024-12-12T15:41:38.8280000", "2024-12-12T15:41:38.8289876")]
    [InlineData("2024-12-12T15:41:38.8200000", "2024-12-12T15:41:38.8209876")]
    [InlineData("2024-12-12T14:48:27.2540000-05:00", "2024-12-12T14:48:27.2549876-05:00")]
    [InlineData("2024-12-12T14:48:27.2540000Z", "2024-12-12T14:48:27.2549876Z")]
    public void FillMicroseconds(string input, string expected)
    {
        var fakeMicroseconds = "9876";
        var actual = Web.Client.Services.Extensions.FillMicroseconds(input, fakeMicroseconds);

        Assert.Equal(expected, actual);
    }
}