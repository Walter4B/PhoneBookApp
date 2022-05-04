using ConsoleTableExt;

namespace PhoneBookApp
{
    internal class TableDisplayEngine
    {
        internal void DisplayPhoneBook(List<Models.Contact> ListOfTableLines, string[] ColumnNames)
        {

            ConsoleTableBuilder
                .From(ListOfTableLines)
                .WithColumn(ColumnNames)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine();
        }

    }
}
