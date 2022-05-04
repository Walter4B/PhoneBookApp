using ConsoleTableExt;
using PhoneBookApp.Models;

namespace PhoneBookApp
{
    internal class TableDisplayEngine
    {
        internal void DisplayPhoneBook(List<Contact> ListOfTableLines, string[] ColumnNames)
        {

            ConsoleTableBuilder
                .From(ListOfTableLines)
                .WithColumn(ColumnNames)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine();
        }

    }
}
