using System.Text.RegularExpressions;

namespace PhoneBookApp
{
    internal class Validator
    {
        internal bool ValidateInt(string input)
        {
            if (Int32.TryParse(input, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool CheckIfEmptyNull(string input)
        { 
            return string.IsNullOrEmpty(input);
        }

        internal bool CheckNumberFormat(string input)
        {
            Regex regex = new Regex(@"[\+][1]{1}\s+[2-9]{1}[0-9]{2}-[2-9]{1}[0-9]{2}-[0-9]{4}", RegexOptions.ECMAScript);
            Match match = regex.Match(input);
            if (match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
