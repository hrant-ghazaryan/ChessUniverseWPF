namespace ChessUniverse.Library.Pieces;

public class Bishop(PieceColor color) : Piece(color, PieceType.Bishop)
{
    public override char GetSymbol() => color == PieceColor.White ? 'B' : 'b';
}