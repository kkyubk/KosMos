using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace Desktop
{
   
    public class InputValidator
    {
        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Here we use regular expression to validate email
                return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool ValidatePassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 6;
        }

        public static bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Length >= 3;
        }
    }
}

