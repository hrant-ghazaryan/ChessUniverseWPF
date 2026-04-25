namespace ChessUniverse.Library.Pieces;

public class Pawn(PieceColor color) : Piece(color, PieceType.Pawn)
{
    public override char GetSymbol() => color == PieceColor.White ? 'P' : 'p';
}