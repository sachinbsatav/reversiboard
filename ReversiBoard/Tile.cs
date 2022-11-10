namespace ReversiBoard;


public enum TileState
{
    Black = -1,
    Empty = 0,
    White = 1,
}
public class Tile
{
    public TileState State { get; set; } = TileState.Empty;
    public Tuple<int, int> Position { get; set; } = new Tuple<int, int>(-1, -1);
}
