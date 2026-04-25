namespace ChessUniverse.Library.Pieces;

internal class Rook(PieceColor color) : Piece(color, PieceType.Rook)
{
    public override char GetSymbol() => color == PieceColor.White ? 'R' : 'r';
}