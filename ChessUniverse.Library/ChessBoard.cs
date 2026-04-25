using ChessUniverse.Library.Pieces;

namespace ChessUniverse.Library;

public class ChessBoard
{
    private Piece?[,] _squares = new Piece?[8, 8];
    public Piece? this[int row, int col]
    {
        get => _squares[row, col];
        set => _squares[row, col] = value;
    }

    public void SetStartPosition()
    {
        Array.Clear(_squares, 0, _squares.Length);

        _squares[0, 0] = new Rook(PieceColor.Black);   // a8
        _squares[0, 1] = new Knight(PieceColor.Black); // b8
        _squares[0, 2] = new Bishop(PieceColor.Black); // c8
        _squares[0, 3] = new Queen(PieceColor.Black);  // d8
        _squares[0, 4] = new King(PieceColor.Black);   // e8
        _squares[0, 5] = new Bishop(PieceColor.Black); // f8
        _squares[0, 6] = new Knight(PieceColor.Black); // g8
        _squares[0, 7] = new Rook(PieceColor.Black);   // h8

        for (int col = 0; col < 8; col++)
        {
            _squares[1, col] = new Pawn(PieceColor.Black);
        }

        for (int col = 0; col < 8; col++)
        {
            _squares[6, col] = new Pawn(PieceColor.White);
        }

        _squares[7, 0] = new Rook(PieceColor.White);   // a1
        _squares[7, 1] = new Knight(PieceColor.White); // b1
        _squares[7, 2] = new Bishop(PieceColor.White); // c1
        _squares[7, 3] = new Queen(PieceColor.White);  // d1
        _squares[7, 4] = new King(PieceColor.White);   // e1
        _squares[7, 5] = new Bishop(PieceColor.White); // f1
        _squares[7, 6] = new Knight(PieceColor.White); // g1
        _squares[7, 7] = new Rook(PieceColor.White);   // h1
    }

    public Piece? this[string coordinate]
    {
        get
        {
            if (coordinate.Length != 2) return null;

            char file = coordinate[0]; // a-h
            char rank = coordinate[1]; // 1-8

            int col = file - 'a';
            int row = 8 - (rank - '0');

            if (row < 0 || row > 7 || col < 0 || col > 7) return null;

            return _squares[row, col];
        }
    }
}