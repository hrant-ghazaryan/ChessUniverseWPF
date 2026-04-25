namespace ChessUniverse.Library;

public class Piece(PieceColor color, PieceType type)
{
    public PieceColor Color { get; }
    public PieceType Type { get; }
    
    public virtual char GetSymbol()
    {
        return '?';
    }
    public virtual bool CanMoveTo(int startRow, int startCol, int endRow, int endCol)
    {
        return false;
    }
}