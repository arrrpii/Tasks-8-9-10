class Chessboard
{
    static void Main()
    {

        string[,] chess = new string[8, 8];

        for (int i = 0; i < chess.GetLength(0); i++)
        {
            for (int j = 0; j < chess.GetLength(1); j++)
            {
                chess[i, j] = "0 ";
            }
        }

        Console.WriteLine();
        Console.Write("Enter the row number ");
        int r = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter the column number ");
        int c = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();

        chess[r, c] = "K ";

        int[,] temp = {
                {2, 3, 4, 4, 4, 4, 3, 2},
                {3, 4, 6, 6, 6, 6, 4, 3},
                {4, 6, 8, 8, 8, 8, 6, 4},
                {4, 6, 8, 8, 8, 8, 6, 4},
                {4, 6, 8, 8, 8, 8, 6, 4},
                {4, 6, 8, 8, 8, 8, 6, 4},
                {3, 4, 6, 6, 6, 6, 4, 3},
                {2, 3, 4, 4, 4, 4, 3, 2}
        };

        bool var;
        do
        {
            int min = 8;
            int mr = 0;
            int mc = 0;
            int m = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chess[i, j] == "K ")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(chess[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (((r - i == 2 || i - r == 2) && (c - j == 1 || j - c == 1) || (r - i == 1 || i - r == 1) && (c - j == 2 || j - c == 2)))
                    {
                        if (temp[i, j] <= min)
                        {
                            min = temp[i, j];
                            mr = i;
                            mc = j;
                            m++;
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(temp[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(chess[i, j]);
                    }
                }
                Console.WriteLine();
            }

            r = mr;
            c = mc;
            chess[r, c] = "K ";
            Console.WriteLine();

            Console.Write("Do you want to continue? ");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (answer == "y" && m != 0)
            {
                var = true;
            }
            else
            {
                var = false;
                if (m == 0)
                {
                    Console.WriteLine("No choice is found.");
                }
            }

        } while (var);

    }
}
