using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class InputController
    {
        internal int GetInputInt()
        {
            string input = Console.ReadLine();
            int validInput = 0;
            return validInput;
        }

        internal string GetInputString()
        {
            string input = Console.ReadLine();
            return input;
        }

        internal string GetInputPhoneNumber()
        {
            string input = Console.ReadLine();
            string validInput = "";
            return validInput;
        }
    }
}
