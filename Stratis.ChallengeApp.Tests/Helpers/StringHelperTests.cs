using Stratis.ChallengeApp.Helpers;
using Xunit;

namespace Stratis.ChallengeApp.Tests.Helpers
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("5")]
        [InlineData("8")]
        [InlineData("9")]
        [InlineData("15")]
        public void ValidateUserInput_Should_Return_True(string input)
        {
            var response = input.ValidateUserInput();
            Assert.True(response);
        }


        [Theory]
        [InlineData("0")]
        [InlineData("38")]
        [InlineData("94")]
        [InlineData("asdf")]
        [InlineData("  ")]
        public void ValidateUserInput_Should_Return_False(string input)
        {
            var response = input.ValidateUserInput();
            Assert.False(response);
        }
    }
}
