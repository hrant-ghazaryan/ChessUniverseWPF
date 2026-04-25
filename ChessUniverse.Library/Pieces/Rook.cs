namespace ChessUniverse.Library.Pieces;

public class Rook(PieceColor color) : Piece(color, PieceType.Rook)
{
    public override char GetSymbol() => color == PieceColor.White ? 'R' : 'r';
}