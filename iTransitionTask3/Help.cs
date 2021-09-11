using ConsoleTables;
using System.Collections.Generic;
using System.Linq;

namespace iTransitionTask3
    {
    class Help
        {
        public static void ShowTable(List<Turn> turns)
            {
            var table = new ConsoleTable("1");

            //foreach (Turn turn in turns)
            //    {
            //    table.Columns.Add(turn.Name);
            //    }
            //var rows = Enumerable.Repeat(turns, turns.Count());
            //table.AddRow(rows);
            //ConsoleTable
            //    .From(rows)
            //    .Configure(o => o.NumberAlignment = Alignment.Right)
            //    .Write();
            }
        }
    }
