using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class UserController
    {
        OutputController outputController = new OutputController();
        InputController inputController = new InputController();   

        internal void UserControlls()
        {
            bool running = true;
            while (running)
            {
                int input = inputController.GetInputInt();
                switch (input)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
