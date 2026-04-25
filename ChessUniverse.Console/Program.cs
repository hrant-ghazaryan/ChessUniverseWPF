using static System.Console;
using ChessUniverse.Library;

ChessBoard board = new ChessBoard();
board.SetStartPosition();

PrintBoard(board);
ReadKey();

static void PrintBoard(ChessBoard board)
{
    WriteLine("    a  b  c  d  e  f  g  h");
    WriteLine("  ┌────────────────────────┐");

    for (int row = 0; row < 8; row++)
    {
        Write($"{8 - row} │");

        for (int col = 0; col < 8; col++)
        {
            bool isLightSquare = (row + col) % 2 == 0;
            BackgroundColor = isLightSquare ? ConsoleColor.Gray : ConsoleColor.DarkGray;
            ForegroundColor = isLightSquare ? ConsoleColor.Black : ConsoleColor.White;

            var piece = board[row, col];
            //char symbol = piece?.GetSymbol() ?? '.';
            char symbol;
            if (piece != null)
            {
                symbol = piece.GetSymbol();
            }
            else
            {
                symbol = '.';
            }

            Write($" {symbol} ");
        }

        ResetColor();
        WriteLine("│");
    }

    WriteLine("  └────────────────────────┘");
    WriteLine("    a  b  c  d  e  f  g  h");
}
