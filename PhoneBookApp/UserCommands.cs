namespace PhoneBookApp
{
    internal class UserCommands
    {
        OutputEngine outputController = new OutputEngine();
        InputEngine inputController = new InputEngine();   
        DatabaseController databaseController = new DatabaseController();

        internal void UserControlls()
        {
            bool running = true;
            while (running)
            {
                outputController.DisplayMessage("MainMenu");
                int input = inputController.GetInputInt();
                switch (input)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        Console.Clear();
                        databaseController.AddEntryToDatabase();
                        break;
                    case 2:
                        Console.Clear();
                        databaseController.RemoveEntryFromDatabase();
                        break;
                    case 3:
                        Console.Clear();
                        databaseController.UpdateEntryInDatabase();
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
