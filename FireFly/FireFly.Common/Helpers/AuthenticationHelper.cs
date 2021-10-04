using System.Text.RegularExpressions;

namespace FireFly.Common.Helpers
{

    public class AuthenticationHelper
    {
        string emailValidationRegex = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";

        public bool IsEmailValid(string email)
        {
            var result = Regex.IsMatch(email, emailValidationRegex);

            return result;
        }

        public bool IsPasswordValid(string password)
        {
            return !string.IsNullOrEmpty(password);
        }

        public bool IsPasswordsEqual(string password, string passwordConfirm)
        {
            if (password != passwordConfirm)
                return false;

            return true;
        }
    }
}