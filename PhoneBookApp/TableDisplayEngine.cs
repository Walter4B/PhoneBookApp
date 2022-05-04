using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace PhoneBookApp
{
    internal class TableDisplayEngine
    {
        internal void DisplayPhoneBook(List<object> ListOfTableLines, List<string> ColumnNames)
        {

            ConsoleTableBuilder
                .From(ListOfTableLines)
                .WithColumn(ColumnNames)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine();
        }

    }
}
