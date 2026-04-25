namespace ChessUniverse.Library.Pieces;

public class King(PieceColor color) : Piece(color, PieceType.King)
{
    public override char GetSymbol() => color == PieceColor.White ? 'K' : 'k';
}