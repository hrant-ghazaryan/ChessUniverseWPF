namespace ChessUniverse.Library.Pieces;

public class Knight(PieceColor color) : Piece(color, PieceType.Knight)
{
    public override char GetSymbol() => color == PieceColor.White ? 'N' : 'n';
}