namespace ChessUniverse.Library.Pieces;

public class Queen(PieceColor color) : Piece(color, PieceType.Queen)
{
    public override char GetSymbol() => color == PieceColor.White ? 'Q' : 'q';
}