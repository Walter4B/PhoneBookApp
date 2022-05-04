using Microsoft.Extensions.Configuration;

namespace PhoneBookApp
{
    internal class OutputController
    {
        private readonly IConfiguration configuration = GetConfig();

        internal void DisplayMessage(string message)
        {
            Console.WriteLine(configuration[message]);
        }

        internal static IConfiguration GetConfig()
        {
            var bulder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("PhoneBookApp/MessageList.json");
            return bulder.Build();
        }
    }
}
