namespace ChessUniverse.Library.Pieces;

internal class Pawn(PieceColor color) : Piece(color, PieceType.Pawn)
{
    public override char GetSymbol() => color == PieceColor.White ? 'P' : 'p';
}