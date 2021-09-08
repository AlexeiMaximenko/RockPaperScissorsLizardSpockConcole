//using ConsoleTables;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace iTransitionTask3
//    {
//    class Help
//        {
//        public static void Table(List<Turn> turns)
//            {
//            var table = new ConsoleTable("Pc/User");

//            foreach (Turn turn in turns)
//                {
//                table.Columns.Add(turn.GetName());









//                var rows = Enumerable.Repeat(new Something(), 10);



//                ConsoleTable.From<Something>(rows).Write();

//                rows = Enumerable.Repeat(new Something(), 0);
//                ConsoleTable.From<Something>(rows).Write();

//                Console.WriteLine("\nNumberAlignment = Alignment.Right\n");
//                rows = Enumerable.Repeat(new Something(), 2);
//                ConsoleTable
//                    .From(rows)
//                    .Configure(o => o.NumberAlignment = Alignment.Right)
//                    .Write();

//                var noCount =
//                new ConsoleTable(new ConsoleTableOptions
//                    {
//                    Columns = new[] { "one", "two", "three" },
//                    EnableCount = false
//                    });

//                noCount.AddRow(1, 2, 3).Write();

//                Console.ReadKey();
//                }
//            }



//        }

    
    
//}
