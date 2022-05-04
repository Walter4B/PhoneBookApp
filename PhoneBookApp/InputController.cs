namespace PhoneBookApp
{
    internal class InputController
    {
        OutputController outputController = new OutputController();
        Validator validator = new Validator();
        internal int GetInputInt()
        {
            string input = Console.ReadLine();
            while (!validator.ValidateInt(input))
            {
                outputController.DisplayMessage("InvalidInput");
                input = Console.ReadLine();
            }
            return Convert.ToInt32(input);
        }

        internal string GetInputString()
        {
            string input = Console.ReadLine();
            while (validator.CheckIfEmptyNull(input))
            {
                outputController.DisplayMessage("InvalidInput");
                input = Console.ReadLine();
            }
            return input;
        }

        internal string GetInputPhoneNumber()
        {
            string input = Console.ReadLine();
            while (validator.CheckNumberFormat(input))
            {
                outputController.DisplayMessage("InvalidInput");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
