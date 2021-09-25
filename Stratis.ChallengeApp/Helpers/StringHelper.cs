using Stratis.ChallengeApp.Constants;

namespace Stratis.ChallengeApp.Helpers
{
    public static class StringHelper
    {
        public static bool ValidateUserInput(this string input)
        {
            int.TryParse(input, out int userInput);
            if (userInput >= GlobalConstants.UserInputMinimumValue && userInput <= GlobalConstants.UserInputMaximumValue)
            {
                return true;
            }
           
            return false;
        }
    }
}
