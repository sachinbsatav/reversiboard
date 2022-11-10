namespace ReversiBoard;

public enum PlayerColor
{
    Black = -1,
    White = 1
}

public class Player
{
    public PlayerColor Color { get; set; }
}
