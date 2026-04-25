namespace ChessUniverse.Library;

public class Coordinate
{
    public int Row { get; }
    public int Col { get; }
    public Coordinate(int row, int col)
    {
        if (row < 0 || row > 7) throw new ArgumentOutOfRangeException(nameof(row), "Row must be between 0 and 7.");
        if (col < 0 || col > 7) throw new ArgumentOutOfRangeException(nameof(col), "Column must be between 0 and 7.");
        Row = row;
        Col = col;
    }

    public static Coordinate FromString(string coord)
    {
        if (string.IsNullOrEmpty(coord) || coord.Length != 2)
            throw new ArgumentException("Coordinate must be 2 characters (e.g. 'e2')");

        char file = coord[0]; // a-h
        char rank = coord[1]; // 1-8

        if (file < 'a' || file > 'h' || rank < '1' || rank > '8')
            throw new ArgumentException("The coordinate is incorrect (use a1 - h8)");

        int col = file - 'a';
        int row = 8 - (rank - '0');

        return new Coordinate(row, col);
    }

    public override string ToString()
    {
        char file = (char)('a' + Col);
        char rank = (char)('1' + (7 - Row));
        return $"{file}{rank}";
    }
}