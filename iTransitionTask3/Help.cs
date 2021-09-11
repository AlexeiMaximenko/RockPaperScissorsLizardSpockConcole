using ConsoleTables;

namespace iTransitionTask3
    {
    class Help
        {
        public static void ShowTable(string[] arg)
            {
            var table = new ConsoleTable("Pc/User");
            table.AddColumn(arg);
            for (int j = 0; j < arg.Length; j++)
                {
                string[] row = new string[arg.Length + 1];
                row[0] = arg[j];
                for (int i = 0; i < arg.Length; i++)
                    {
                    row[i + 1] = GameResult.Calculate(i, j, arg.Length);
                    }
                table.AddRow(row);
                }
            
            table.Write(Format.Alternative);
            }
        }
    }
