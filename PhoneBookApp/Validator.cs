using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Validator
    {
        internal bool ValidateInt()
        {
            return true;
        }

        internal bool CheckEmptyNull()
        { 
            return false;
        }

        internal bool CheckNumberFormat()
        {
            Console.WriteLine("+1 200-200-0000");
            return true;
        }
    }
}
