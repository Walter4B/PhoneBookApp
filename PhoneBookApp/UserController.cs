namespace PhoneBookApp
{
    internal class UserController
    {
        OutputController outputController = new OutputController();
        InputController inputController = new InputController();   
        DatabaseController databaseController = new DatabaseController();

        internal void UserControlls()
        {
            bool running = true;
            while (running)
            {
                outputController.DisplayMessage("MainMenu");
                int input = inputController.GetInputInt();
                string name, number;
                int id;
                switch (input)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        Console.Clear();
                        outputController.DisplayMessage("InputName");
                        name = inputController.GetInputString();
                        outputController.DisplayMessage("InputNumber");
                        number = inputController.GetInputPhoneNumber();
                        databaseController.AddEntryToDatabase(name, number);
                        break;
                    case 2:
                        Console.Clear();
                        outputController.DisplayMessage("DeleteContact");
                        id = inputController.GetInputInt();
                        databaseController.RemoveEntryFromDatabase(id);
                        break;
                    case 3:
                        Console.Clear();
                        outputController.DisplayMessage("UpdateChooseID");
                        id=inputController.GetInputInt();
                        outputController.DisplayMessage("InputName");
                        name=inputController.GetInputString();
                        outputController.DisplayMessage("InputNumber");
                        number=inputController.GetInputPhoneNumber();
                        databaseController.UpdateEntryInDatabase(id, name, number);
                        break;
                    case 4:
                        Console.Clear();
                        databaseController.DisplayAllEntries();
                        break;
                    default:
                        outputController.DisplayMessage("OutOfRange");
                        break;
                }
            }
        }
    }
}
