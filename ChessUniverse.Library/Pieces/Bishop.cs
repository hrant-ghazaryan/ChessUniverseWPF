namespace ChessUniverse.Library.Pieces;

internal class Bishop(PieceColor color) : Piece(color, PieceType.Bishop)
{
    public override char GetSymbol() => color == PieceColor.White ? 'B' : 'b';
}